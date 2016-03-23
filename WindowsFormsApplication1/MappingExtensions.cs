
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public static class MappingExtensions
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
        {
            var properties = typeof(T).GetProperties();

            DataTable dt = new DataTable();

            // columns
            foreach (PropertyInfo property in properties)
            {
                dt.Columns.Add(new DataColumn(property.Name, property.PropertyType));
            }

            foreach (T obj in collection)
            {
                DataRow row = dt.NewRow();

                foreach (PropertyInfo property in properties)
                {
                    object val = property.GetValue(obj, null);
                    row[property.Name] = val ?? DBNull.Value;
                }
                dt.Rows.Add(row);
            }

            return dt;

        }

        public static List<T> TableToList<T>(this DataTable dt) where T : new()
        {
            BindingFlags defaults = BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase;
            List<PropertyInfo> properties = typeof(T).GetProperties(defaults).ToList();
            Dictionary<string, string> mappedNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            List<T> li = new List<T>();

            // not using lambda's, see article
            // http://blog.jetbrains.com/dotnet/2014/07/24/unusual-ways-of-boosting-up-app-performance-lambdas-and-linqs/
            foreach (DataRow row in dt.AsEnumerable())
            {
                T obj = new T();

                foreach (PropertyInfo property in properties)
                {
                    string mappedName = MappedNameCache(mappedNames, property.Name, property);

                    if (!dt.Columns.Contains(mappedName) || row[mappedName] == DBNull.Value) { continue; }

                    Type targetType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;

                    property.SetValue(obj, Convert.ChangeType(row[mappedName], targetType), null);
                }

                li.Add(obj);
            }

            return li;
        }

        public static TResult MapProperties<TSource, TResult>(this TSource src)
            where TResult : new()
        {
            BindingFlags defaults = BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase;
            List<PropertyInfo> properties = typeof(TResult).GetProperties(defaults)
                .Where(p => p.GetCustomAttributes(false).OfType<MappedNameAttribute>().Any())
                .ToList<PropertyInfo>();
            Type srcType = typeof(TSource);
            Dictionary<string, string> mappedNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            TResult obj = new TResult();

            foreach (PropertyInfo property in properties)
            {
                string mappedName = MappedNameCache(mappedNames, property.Name, property);
                var srcValue = srcType.GetProperty(mappedName).GetValue(src, null);

                Type conversionType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                property.SetValue(obj, Convert.ChangeType(srcValue, conversionType), null);
            }

            return obj;
        }

        public static IEnumerable<TResult> MapProperties<TSource, TResult>(this IEnumerable<TSource> srcs)
            where TResult : new()
        {
            List<TResult> li = new List<TResult>();

            foreach (TSource src in srcs)
            {
                li.Add(src.MapProperties<TSource, TResult>());
            }

            return li;
        }

        public static TResult MapProperties<TSource, TResult>(this TSource src, TResult destination)
            where TResult : class
        {
            BindingFlags defaults = BindingFlags.Instance | BindingFlags.Public | BindingFlags.IgnoreCase;
            List<PropertyInfo> properties = typeof(TResult).GetProperties(defaults)
                .Where(p => p.GetCustomAttributes(false).OfType<MappedNameAttribute>().Any())
                .ToList<PropertyInfo>();
            Type srcType = typeof(TSource);
            Dictionary<string, string> mappedNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            foreach (PropertyInfo property in properties)
            {
                string mappedName = MappedNameCache(mappedNames, property.Name, property);

                var srcValue = srcType.GetProperty(mappedName).GetValue(src, null);

                Type conversionType = Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType;
                property.SetValue(destination, Convert.ChangeType(srcValue, conversionType), null);
            }

            return destination;
        }

        private static string MappedNameCache(Dictionary<string, string> cache, string key, PropertyInfo property)
        {
            string columnName;
            if (!cache.TryGetValue(key, out columnName))
            {
                MappedNameAttribute customAttribute = property.GetCustomAttribute<MappedNameAttribute>();

                columnName = customAttribute != null ? customAttribute.Name : property.Name;
                cache.Add(key, columnName);
            }

            return columnName ?? string.Empty;
        }

    }
}
