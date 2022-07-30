
namespace e_Shift_ManagementSystem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_Customer = new e_Shift_ManagementSystem.DataSet_Customer();
            this.tbl_CustomerTableAdapter = new e_Shift_ManagementSystem.DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter();
            this.btnRegCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cusStatus = new System.Windows.Forms.TextBox();
            this.cusNIC = new System.Windows.Forms.TextBox();
            this.cusEmail = new System.Windows.Forms.TextBox();
            this.cusContact = new System.Windows.Forms.TextBox();
            this.cusAddress = new System.Windows.Forms.TextBox();
            this.cusName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnUpdateSubmit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Customer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cusNameDataGridViewTextBoxColumn,
            this.cusNICDataGridViewTextBoxColumn,
            this.cusAddressDataGridViewTextBoxColumn,
            this.cusEmailDataGridViewTextBoxColumn,
            this.cusStatusDataGridViewTextBoxColumn,
            this.cusContactDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCustomerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(113, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(751, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusNameDataGridViewTextBoxColumn
            // 
            this.cusNameDataGridViewTextBoxColumn.DataPropertyName = "cusName";
            this.cusNameDataGridViewTextBoxColumn.HeaderText = "cusName";
            this.cusNameDataGridViewTextBoxColumn.Name = "cusNameDataGridViewTextBoxColumn";
            // 
            // cusNICDataGridViewTextBoxColumn
            // 
            this.cusNICDataGridViewTextBoxColumn.DataPropertyName = "cusNIC";
            this.cusNICDataGridViewTextBoxColumn.HeaderText = "cusNIC";
            this.cusNICDataGridViewTextBoxColumn.Name = "cusNICDataGridViewTextBoxColumn";
            // 
            // cusAddressDataGridViewTextBoxColumn
            // 
            this.cusAddressDataGridViewTextBoxColumn.DataPropertyName = "cusAddress";
            this.cusAddressDataGridViewTextBoxColumn.HeaderText = "cusAddress";
            this.cusAddressDataGridViewTextBoxColumn.Name = "cusAddressDataGridViewTextBoxColumn";
            // 
            // cusEmailDataGridViewTextBoxColumn
            // 
            this.cusEmailDataGridViewTextBoxColumn.DataPropertyName = "cusEmail";
            this.cusEmailDataGridViewTextBoxColumn.HeaderText = "cusEmail";
            this.cusEmailDataGridViewTextBoxColumn.Name = "cusEmailDataGridViewTextBoxColumn";
            // 
            // cusStatusDataGridViewTextBoxColumn
            // 
            this.cusStatusDataGridViewTextBoxColumn.DataPropertyName = "cusStatus";
            this.cusStatusDataGridViewTextBoxColumn.HeaderText = "cusStatus";
            this.cusStatusDataGridViewTextBoxColumn.Name = "cusStatusDataGridViewTextBoxColumn";
            // 
            // cusContactDataGridViewTextBoxColumn
            // 
            this.cusContactDataGridViewTextBoxColumn.DataPropertyName = "cusContact";
            this.cusContactDataGridViewTextBoxColumn.HeaderText = "cusContact";
            this.cusContactDataGridViewTextBoxColumn.Name = "cusContactDataGridViewTextBoxColumn";
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "Tbl_Customer";
            this.tblCustomerBindingSource.DataSource = this.dataSet_Customer;
            // 
            // dataSet_Customer
            // 
            this.dataSet_Customer.DataSetName = "DataSet_Customer";
            this.dataSet_Customer.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // btnRegCustomer
            // 
            this.btnRegCustomer.Location = new System.Drawing.Point(182, 742);
            this.btnRegCustomer.Name = "btnRegCustomer";
            this.btnRegCustomer.Size = new System.Drawing.Size(165, 50);
            this.btnRegCustomer.TabIndex = 4;
            this.btnRegCustomer.Text = "Register";
            this.btnRegCustomer.UseVisualStyleBackColor = true;
            this.btnRegCustomer.Click += new System.EventHandler(this.btnRegCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Management";
            // 
            // cusStatus
            // 
            this.cusStatus.Location = new System.Drawing.Point(329, 640);
            this.cusStatus.Name = "cusStatus";
            this.cusStatus.Size = new System.Drawing.Size(418, 20);
            this.cusStatus.TabIndex = 12;
            // 
            // cusNIC
            // 
            this.cusNIC.Location = new System.Drawing.Point(329, 593);
            this.cusNIC.Name = "cusNIC";
            this.cusNIC.Size = new System.Drawing.Size(418, 20);
            this.cusNIC.TabIndex = 13;
            // 
            // cusEmail
            // 
            this.cusEmail.Location = new System.Drawing.Point(329, 551);
            this.cusEmail.Name = "cusEmail";
            this.cusEmail.Size = new System.Drawing.Size(418, 20);
            this.cusEmail.TabIndex = 14;
            // 
            // cusContact
            // 
            this.cusContact.Location = new System.Drawing.Point(329, 503);
            this.cusContact.Name = "cusContact";
            this.cusContact.Size = new System.Drawing.Size(418, 20);
            this.cusContact.TabIndex = 15;
            // 
            // cusAddress
            // 
            this.cusAddress.Location = new System.Drawing.Point(329, 452);
            this.cusAddress.Name = "cusAddress";
            this.cusAddress.Size = new System.Drawing.Size(418, 20);
            this.cusAddress.TabIndex = 16;
            // 
            // cusName
            // 
            this.cusName.Location = new System.Drawing.Point(329, 405);
            this.cusName.Name = "cusName";
            this.cusName.Size = new System.Drawing.Size(418, 20);
            this.cusName.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 643);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 596);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "NIC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Customer Name";
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.Red;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(675, 742);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(142, 50);
            this.btnDeleteCustomer.TabIndex = 23;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnUpdateSubmit
            // 
            this.btnUpdateSubmit.Location = new System.Drawing.Point(437, 742);
            this.btnUpdateSubmit.Name = "btnUpdateSubmit";
            this.btnUpdateSubmit.Size = new System.Drawing.Size(156, 50);
            this.btnUpdateSubmit.TabIndex = 22;
            this.btnUpdateSubmit.Text = "Update";
            this.btnUpdateSubmit.UseVisualStyleBackColor = true;
            this.btnUpdateSubmit.Click += new System.EventHandler(this.btnUpdateSubmit_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(329, 366);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(418, 20);
            this.txtID.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Customer ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 827);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnUpdateSubmit);
            this.Controls.Add(this.cusStatus);
            this.Controls.Add(this.cusNIC);
            this.Controls.Add(this.cusEmail);
            this.Controls.Add(this.cusContact);
            this.Controls.Add(this.cusAddress);
            this.Controls.Add(this.cusName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet_Customer dataSet_Customer;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter tbl_CustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRegCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cusStatus;
        private System.Windows.Forms.TextBox cusNIC;
        private System.Windows.Forms.TextBox cusEmail;
        private System.Windows.Forms.TextBox cusContact;
        private System.Windows.Forms.TextBox cusAddress;
        private System.Windows.Forms.TextBox cusName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnUpdateSubmit;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
    }
}

