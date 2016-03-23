using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Application.Run(new EmailAddressForm2());
            DataTable dt;
            using (DatabaseConnection db = new DatabaseConnection(@".\SQLEXPRESS", "Practice"))
            {
                dt = db.queryDataToDataTable("Select *, EmailAddress as Email from Person.EmailAddress");
            }

            List<EmailAddress> list = new List<EmailAddress>();
           
            foreach (DataRow dataRow in dt.Rows)
            {               
                EmailAddress e = new EmailAddress(dataRow.Field<int>("BusinessEntityID"), dataRow.Field<int>("EmailAddressID"), dataRow.Field<string>("Email"));
                list.Add(e);
            }

            foreach (EmailAddress e in list)
            {
                Console.WriteLine(e.toString());
            }
        }
    }
}
