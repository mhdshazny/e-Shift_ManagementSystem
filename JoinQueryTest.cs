using e_Shift_ManagementSystem.Services;
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
    public partial class JoinQueryTest : Form
    {
        public JoinQueryTest()
        {
            InitializeComponent();
        }

        private void JoinQueryTest_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void LoadData()
        {
            OrderCRUD obj = new OrderCRUD();
            DataTable dataTable =  obj.GetAll();
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();

            comboBox1.DataSource = obj.GetCustomerList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            OrderCRUD obj = new OrderCRUD(
                   int.Parse(comboBox1.SelectedValue.ToString()),
                   txtOrderItem.Text,
                   txtDescr.Text,
                   txtStatus.Text
                );

            obj.InsertOrder();

            LoadData();

        }
    }
}
