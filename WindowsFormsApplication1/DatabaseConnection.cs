using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DatabaseConnection : IDisposable

    {

        SqlConnection conn;

        public DatabaseConnection(string server, string database)
        {

           this.conn = new SqlConnection();
           this.conn.ConnectionString =
            "Data Source=" + server + ";" +
            "Initial Catalog= " + database + ";" +
            "Integrated Security=true;";
            this.conn.Open();
  
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public DataTable queryDataToDataTable (string query)
        {
           // Func<string, int> fn = s => s.GetHashCode();

           // var i = fn("");

            

            DataTable dt = new DataTable();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, this.conn))
            {

                adapter.Fill(dt);
            }

            return dt ?? new DataTable();
            //SqlCommand command = new SqlCommand(query, this.conn);
            //SqlDataReader reader = command.ExecuteReader();
            //int cols = reader.FieldCount;

            //DataTable dt = new DataTable();
            //for (int i = 0; i < cols; i++)
            //{
            //    dt.Columns.Add(new DataColumn(reader.GetName(i), reader.GetFieldType(i)));
            //}

            //while (reader.Read())
            //{
            //    DataRow row = dt.NewRow();
            //    for (int i=0; i< cols; i++)
            //    {
            //        row[i] = reader[i];
            //    }
            //    dt.Rows.Add(row);
            //}
        }


        public void addRowToDatabase(String tableName, params SqlParameter[] prms)
        {
            String query = "insert into " + tableName + " (";
            foreach (SqlParameter p in prms)
            {
                query += p.ParameterName + ",";
            }
            query += ") values(";
            foreach (SqlParameter p in prms)
            {
                query += p.Value + ",";
            }
            query += ");";
            SqlCommand command = new SqlCommand(query, this.conn);
            command.ExecuteNonQuery();
                        

            }
    }
}
