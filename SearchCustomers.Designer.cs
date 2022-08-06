
namespace e_Shift_ManagementSystem
{
    partial class SearchCustomers
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
            this.layout = new System.Windows.Forms.Panel();
            this.gridViewArea = new System.Windows.Forms.GroupBox();
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
            this.searchArea = new System.Windows.Forms.GroupBox();
            this.rdbtnInactive = new System.Windows.Forms.RadioButton();
            this.rdbtnActive = new System.Windows.Forms.RadioButton();
            this.rdbtnAll = new System.Windows.Forms.RadioButton();
            this.txtSearchVal = new System.Windows.Forms.TextBox();
            this.tbl_CustomerTableAdapter = new e_Shift_ManagementSystem.DataSet_CustomerTableAdapters.Tbl_CustomerTableAdapter();
            this.layout.SuspendLayout();
            this.gridViewArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Customer)).BeginInit();
            this.searchArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // layout
            // 
            this.layout.Controls.Add(this.gridViewArea);
            this.layout.Controls.Add(this.searchArea);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(1066, 609);
            this.layout.TabIndex = 0;
            // 
            // gridViewArea
            // 
            this.gridViewArea.Controls.Add(this.dataGridView1);
            this.gridViewArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewArea.Location = new System.Drawing.Point(0, 118);
            this.gridViewArea.Name = "gridViewArea";
            this.gridViewArea.Size = new System.Drawing.Size(1066, 491);
            this.gridViewArea.TabIndex = 0;
            this.gridViewArea.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1060, 472);
            this.dataGridView1.TabIndex = 0;
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
            // searchArea
            // 
            this.searchArea.Controls.Add(this.rdbtnInactive);
            this.searchArea.Controls.Add(this.rdbtnActive);
            this.searchArea.Controls.Add(this.rdbtnAll);
            this.searchArea.Controls.Add(this.txtSearchVal);
            this.searchArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchArea.Location = new System.Drawing.Point(0, 0);
            this.searchArea.Name = "searchArea";
            this.searchArea.Size = new System.Drawing.Size(1066, 118);
            this.searchArea.TabIndex = 0;
            this.searchArea.TabStop = false;
            // 
            // rdbtnInactive
            // 
            this.rdbtnInactive.AutoSize = true;
            this.rdbtnInactive.Location = new System.Drawing.Point(511, 54);
            this.rdbtnInactive.Name = "rdbtnInactive";
            this.rdbtnInactive.Size = new System.Drawing.Size(63, 17);
            this.rdbtnInactive.TabIndex = 3;
            this.rdbtnInactive.TabStop = true;
            this.rdbtnInactive.Text = "Inactive";
            this.rdbtnInactive.UseVisualStyleBackColor = true;
            this.rdbtnInactive.CheckedChanged += new System.EventHandler(this.rdbtnInactive_CheckedChanged);
            // 
            // rdbtnActive
            // 
            this.rdbtnActive.AutoSize = true;
            this.rdbtnActive.Location = new System.Drawing.Point(436, 54);
            this.rdbtnActive.Name = "rdbtnActive";
            this.rdbtnActive.Size = new System.Drawing.Size(55, 17);
            this.rdbtnActive.TabIndex = 2;
            this.rdbtnActive.TabStop = true;
            this.rdbtnActive.Text = "Active";
            this.rdbtnActive.UseVisualStyleBackColor = true;
            this.rdbtnActive.CheckedChanged += new System.EventHandler(this.rdbtnActive_CheckedChanged);
            // 
            // rdbtnAll
            // 
            this.rdbtnAll.AutoSize = true;
            this.rdbtnAll.Location = new System.Drawing.Point(383, 54);
            this.rdbtnAll.Name = "rdbtnAll";
            this.rdbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rdbtnAll.TabIndex = 1;
            this.rdbtnAll.TabStop = true;
            this.rdbtnAll.Text = "All";
            this.rdbtnAll.UseVisualStyleBackColor = true;
            this.rdbtnAll.CheckedChanged += new System.EventHandler(this.rdbtnAll_CheckedChanged);
            // 
            // txtSearchVal
            // 
            this.txtSearchVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchVal.Location = new System.Drawing.Point(45, 44);
            this.txtSearchVal.Multiline = true;
            this.txtSearchVal.Name = "txtSearchVal";
            this.txtSearchVal.Size = new System.Drawing.Size(270, 46);
            this.txtSearchVal.TabIndex = 0;
            this.txtSearchVal.TextChanged += new System.EventHandler(this.txtSearchVal_TextChanged);
            // 
            // tbl_CustomerTableAdapter
            // 
            this.tbl_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // SearchCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 609);
            this.Controls.Add(this.layout);
            this.Name = "SearchCustomers";
            this.Text = "SearchCustomers";
            this.Load += new System.EventHandler(this.SearchCustomers_Load);
            this.layout.ResumeLayout(false);
            this.gridViewArea.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_Customer)).EndInit();
            this.searchArea.ResumeLayout(false);
            this.searchArea.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel layout;
        private System.Windows.Forms.GroupBox gridViewArea;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox searchArea;
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
        private System.Windows.Forms.TextBox txtSearchVal;
        private System.Windows.Forms.RadioButton rdbtnInactive;
        private System.Windows.Forms.RadioButton rdbtnActive;
        private System.Windows.Forms.RadioButton rdbtnAll;
    }
}