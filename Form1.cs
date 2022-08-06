using e_Shift_ManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Shift_ManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Customer.Tbl_Customer' table. You can move, or remove it, as needed.
            this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
            InitSetting();
        }

        private void InitSetting()
        {
            btnUpdateSubmit.Enabled = false;
            btnDeleteCustomer.Enabled = false;
            btnRegCustomer.Enabled = true;
            txtID.ReadOnly = true;


            txtID.Text = string.Empty;
            cusAddress.Text = string.Empty;
            cusName.Text = string.Empty;
            cusEmail.Text = string.Empty;
            cusContact.Text = string.Empty;
            cusNIC.Text = string.Empty;
            cusStatus.Text = string.Empty;

        }

        public bool ValidateData()
        {
            bool IsValid = false;

            IsValid = Regex.IsMatch(cusEmail.Text, 
                @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                RegexOptions.IgnoreCase);

            if(!IsValid)
                lblEmailValid.Text = "Email format invalid";
            else
                lblEmailValid.Text = string.Empty;


            return IsValid;
            
        }


        private void btnRegCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                bool FormValid = ValidateData();
                if (FormValid)
                {
                    CustomerCRUD cusCrud = new CustomerCRUD(cusName.Text, cusAddress.Text, cusEmail.Text, cusNIC.Text, cusContact.Text, cusStatus.Text);

                    var result = cusCrud.CreateCustomer();

                    if (result.IsSuccess)
                        MessageBox.Show(result.Message);
                    else
                        MessageBox.Show(result.Message + " :" + result.ErrorMessage);
                }

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
                InitSetting();
            }


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var data = dataGridView1.Rows[e.RowIndex].Cells;

                txtID.Text = data[0].Value.ToString();
                cusName.Text = data[1].Value.ToString();
                cusNIC.Text = data[2].Value.ToString();
                cusAddress.Text = data[3].Value.ToString();
                cusEmail.Text = data[4].Value.ToString();
                cusStatus.Text = data[5].Value.ToString();
                cusContact.Text = data[6].Value.ToString();

                btnUpdateSubmit.Enabled = true;
                btnDeleteCustomer.Enabled = true;
                btnRegCustomer.Enabled = false;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnUpdateSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD cusCrud = new CustomerCRUD(cusName.Text, cusAddress.Text, cusEmail.Text, cusNIC.Text, cusContact.Text, cusStatus.Text);

                var result = cusCrud.UpdateCustomer(txtID.Text);

                if (result.IsSuccess)
                    MessageBox.Show(result.Message);
                else
                    MessageBox.Show(result.Message + " :" + result.ErrorMessage);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);

                InitSetting();
            }

        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerCRUD cusCrud = new CustomerCRUD();

                var result = cusCrud.DeleteCustomer(txtID.Text);

                if (result.IsSuccess)
                    MessageBox.Show(result.Message);
                else
                    MessageBox.Show(result.Message + " :" + result.ErrorMessage);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            finally
            {
                this.tbl_CustomerTableAdapter.Fill(this.dataSet_Customer.Tbl_Customer);
                InitSetting();
            }

        }
    }
}
