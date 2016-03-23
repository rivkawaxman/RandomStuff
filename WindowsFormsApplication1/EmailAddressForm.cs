using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EmailAddressForm : Form
    {
        public EmailAddressForm()
        {
            InitializeComponent();
        }

        private void EmailAddressForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (DatabaseConnection db = new DatabaseConnection(@".\SQLEXPRESS", "Practice"))
            {
                dt = db.queryDataToDataTable("Select BusinessEntityID, EmailAddressID, EmailAddress as Email from Person.EmailAddress");
            }
            List<EmailAddress> list = dt.TableToList<EmailAddress>();
            emailAddressBindingSource.Add(list);
        }
    }
}
