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
    

    public partial class Form1 : Form

       
    {
        public int busEntityID;
        public string emailAdd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practiceDataSet1.EmailAddress' table. You can move, or remove it, as needed.
            this.emailAddressTableAdapter.Fill(this.practiceDataSet1.EmailAddress);
            // TODO: This line of code loads data into the 'practiceDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.practiceDataSet.Employee);

        }

        private void add_Click(object sender, EventArgs e)
        {
            PracticeDataSet1.EmailAddressRow newRow = practiceDataSet1.EmailAddress.NewEmailAddressRow();
            newRow.BusinessEntityID = (Convert.ToInt32(busEntityBox.Text));
      
            newRow.EmailAddressID = (from id in practiceDataSet1.EmailAddress select id.EmailAddressID).Max() + 1;
            newRow.EmailAddress = this.emailAddress.Text;
            this.practiceDataSet1.EmailAddress.Rows.Add(newRow);
            this.emailAddressTableAdapter.Update(this.practiceDataSet1.EmailAddress);
            this.busEntityBox.Text = "";
            this.emailAddress.Text = "";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeTableAdapter.FillBy(this.practiceDataSet.Employee);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
