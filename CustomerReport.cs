using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift_ManagementSystem
{
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet_Customer.Tbl_Customer' table. You can move, or remove it, as needed.
            this.Tbl_CustomerTableAdapter.Fill(this.DataSet_Customer.Tbl_Customer);
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tbl_CustomerTableAdapter.Fill(this.DataSet_Customer.Tbl_Customer);
            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Tbl_CustomerTableAdapter.FillActiveCustomers(this.DataSet_Customer.Tbl_Customer);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Tbl_CustomerTableAdapter.FillInactiveCustomers(this.DataSet_Customer.Tbl_Customer);
            this.reportViewer1.RefreshReport();
        }
    }
}
