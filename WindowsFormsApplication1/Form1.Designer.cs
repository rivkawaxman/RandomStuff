namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practiceDataSet = new WindowsFormsApplication1.PracticeDataSet();
            this.employeeTableAdapter = new WindowsFormsApplication1.PracticeDataSetTableAdapters.EmployeeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.practiceDataSet1 = new WindowsFormsApplication1.PracticeDataSet1();
            this.emailAddressTableAdapter = new WindowsFormsApplication1.PracticeDataSet1TableAdapters.EmailAddressTableAdapter();
            this.busEntityBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailAddress = new System.Windows.Forms.TextBox();
            this.emailAddressBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.businessEntityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(36, 89);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(137, 23);
            this.add.TabIndex = 1;
            this.add.Text = "ADD EMAIL";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(1058, 25);
            this.fillByToolStrip.TabIndex = 2;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.fillByToolStripButton.Text = "Female Employees";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.practiceDataSet;
            // 
            // practiceDataSet
            // 
            this.practiceDataSet.DataSetName = "PracticeDataSet";
            this.practiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.businessEntityIDDataGridViewTextBoxColumn,
            this.Email,
            this.emailAddressIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emailAddressBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(33, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(338, 240);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // emailAddressBindingSource
            // 
            this.emailAddressBindingSource.DataMember = "EmailAddress";
            this.emailAddressBindingSource.DataSource = this.practiceDataSet1;
            // 
            // practiceDataSet1
            // 
            this.practiceDataSet1.DataSetName = "PracticeDataSet1";
            this.practiceDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailAddressTableAdapter
            // 
            this.emailAddressTableAdapter.ClearBeforeFill = true;
            // 
            // busEntityBox
            // 
            this.busEntityBox.CausesValidation = false;
            this.busEntityBox.Location = new System.Drawing.Point(128, 34);
            this.busEntityBox.MaxLength = 4;
            this.busEntityBox.Name = "busEntityBox";
            this.busEntityBox.Size = new System.Drawing.Size(131, 20);
            this.busEntityBox.TabIndex = 4;
            this.busEntityBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Business Entity ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailAddress
            // 
            this.emailAddress.Location = new System.Drawing.Point(116, 63);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Size = new System.Drawing.Size(100, 20);
            this.emailAddress.TabIndex = 7;
            this.emailAddress.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // emailAddressBindingSource1
            // 
            this.emailAddressBindingSource1.DataSource = typeof(WindowsFormsApplication1.EmailAddress);
            // 
            // businessEntityIDDataGridViewTextBoxColumn
            // 
            this.businessEntityIDDataGridViewTextBoxColumn.DataPropertyName = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.HeaderText = "BusinessEntityID";
            this.businessEntityIDDataGridViewTextBoxColumn.Name = "businessEntityIDDataGridViewTextBoxColumn";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // emailAddressIDDataGridViewTextBoxColumn
            // 
            this.emailAddressIDDataGridViewTextBoxColumn.DataPropertyName = "EmailAddressID";
            this.emailAddressIDDataGridViewTextBoxColumn.HeaderText = "EmailAddressID";
            this.emailAddressIDDataGridViewTextBoxColumn.Name = "emailAddressIDDataGridViewTextBoxColumn";
            this.emailAddressIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 524);
            this.Controls.Add(this.emailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busEntityBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practiceDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PracticeDataSet practiceDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private PracticeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private PracticeDataSet1 practiceDataSet1;
        private System.Windows.Forms.BindingSource emailAddressBindingSource;
        private PracticeDataSet1TableAdapters.EmailAddressTableAdapter emailAddressTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox busEntityBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.BindingSource emailAddressBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessEntityIDDataGridViewTextBoxColumn;
    }
}

