using System.Collections.Generic;
using System.Data;


namespace WindowsFormsApplication1
{
    partial class EmailAddressForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.emailAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.businessEntityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessEntityIDDataGridViewTextBoxColumn,
            this.emailAddressIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.emailAddressBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(98, 65);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(339, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // emailAddressBindingSource
            // 
            //this.emailAddressBindingSource.DataSource = typeof(WindowsFormsApplication1.EmailAddress);
            // 
            // businessEntityIDDataGridViewTextBoxColumn
            // 
            this.businessEntityIDDataGridViewTextBoxColumn.DataPropertyName = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.HeaderText = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.Name = "businessEntityIDDataGridViewTextBoxColumn";
            // 
            // emailAddressIDDataGridViewTextBoxColumn
            // 
            this.emailAddressIDDataGridViewTextBoxColumn.DataPropertyName = "EmailAddressID";
            this.emailAddressIDDataGridViewTextBoxColumn.HeaderText = "EmailAddressID";
            this.emailAddressIDDataGridViewTextBoxColumn.Name = "emailAddressIDDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.emailAddressBindingSource, "Email", true));
            this.textBox1.Location = new System.Drawing.Point(98, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 1;
            // 
            // EmailAddressForm
            // 
            this.ClientSize = new System.Drawing.Size(555, 306);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "EmailAddressForm";
            this.Load += new System.EventHandler(this.EmailAddressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessEntityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emailAddressBindingSource;
        private System.Windows.Forms.TextBox textBox1;
    }
}