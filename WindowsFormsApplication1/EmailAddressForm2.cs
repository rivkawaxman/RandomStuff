using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmailAddressForm2 : Form
    {
        BindingSource b = new BindingSource();

        public EmailAddressForm2()
        {
            InitializeComponent();
        }

        private void EmailAddressForm2_Load(object sender, EventArgs e)
        {
            
            //b.DataSource = typeof(EmailAddress);
            DataTable dt = new DataTable();
            using (DatabaseConnection db = new DatabaseConnection(@".\SQLEXPRESS", "Practice"))
            {
                dt = db.queryDataToDataTable("Select BusinessEntityID, EmailAddressID, EmailAddress as Email from Person.EmailAddress");
            }
            List<EmailAddress> list = dt.TableToList<EmailAddress>();
            //b.Add(list);
            BindingList<EmailAddress> bl = new BindingList<EmailAddress>(list);
            BindingSource bSource = new BindingSource(bl, null);

            grid.DataSource = bSource;
            grid.AutoGenerateColumns = true;
            textBox.DataBindings.Add("Text", bSource, "Email");
        }

        private void grid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            DataGridViewRow data = grid.Rows[row];
            using (DatabaseConnection db = new DatabaseConnection(@".\SQLEXPRESS", "Practice"))
            {
                EmailAddress email = data.DataBoundItem as EmailAddress;
                SqlParameter busIdParam = new SqlParameter("BusinessEntityID", email.BusinessEntityID);
                SqlParameter emailId = new SqlParameter("EmailAddressID", email.EmailAddressID);
                SqlParameter emailAddress = new SqlParameter("EmailAddress", email.Email);
                db.addRowToDatabase(@"Person.EmailAddress", busIdParam, emailId, emailAddress);
            }
        }
    }
}
