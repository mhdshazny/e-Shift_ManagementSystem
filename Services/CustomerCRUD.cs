using System;
using System.Data.SqlClient;

namespace e_Shift_ManagementSystem.Services
{
    class CustomerCRUD
    {
        SqlConnection con = new SqlConnection("Data Source=mhd-shazny;Initial Catalog=eshiftDb;Integrated Security=True");

        public CustomerCRUD(string cusName, string cusAddress, string cusEmail, string cusNIC, string cusContact, string cusStatus)
        {
            this.cusName = cusName;
            this.cusAddress = cusAddress;
            this.cusEmail = cusEmail;
            this.cusNIC = cusNIC;
            this.cusContact = cusContact;
            this.cusStatus = cusStatus;
        }

        public CustomerCRUD()
        {
        }

        private int ID { get; set; }
        private string cusName { get; set; }
        private string cusAddress { get; set; }
        private string cusEmail { get; set; }
        private string cusNIC { get; set; }
        private string cusContact { get; set; }
        private string cusStatus { get; set; }


        public Returns CreateCustomer()
        {
            try
            {
                string query = "INSERT INTO Tbl_Customer(cusName,cusNIC,cusAddress," +
                            "cusEmail,cusStatus,cusContact) VALUES('" + cusName + "','" + cusNIC + "'," +
                            "'" + cusAddress + "','" + cusEmail + "','" + cusStatus + "','" + cusContact + "')";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsAdded = com.ExecuteNonQuery();
                if (rowsAdded > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess=true,
                        ErrorMessage=string.Empty,
                        Message="Customer Registered Successfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Customer Registration Failed"
                    };
            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Customer Registration Failed"
                };
            }
            finally
            {
                con.Close();
            }
        } 


        public Returns UpdateCustomer(string ID)
        {
            try
            {
                string query = "Update Tbl_Customer set cusName='" + cusName + "',cusNIC='" + cusNIC + "'," +
                    "cusAddress='" + cusAddress + "',cusEmail='" + cusEmail + "',cusStatus='" + cusStatus + "',cusContact='" + cusContact + "' " +
                    "where Id='" + ID + "'";

                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsUpdated = com.ExecuteNonQuery();
                if (rowsUpdated > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Customer Updated Successfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Customer Update Failed"
                    };


            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Customer Updation Failed"
                };
            }
            finally
            {
                con.Close();
            }
        }

        public Returns DeleteCustomer(string ID)
        {
            try
            {
                string query = "Delete Tbl_Customer where Id='" + ID + "'";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsDeleted = com.ExecuteNonQuery();
                if (rowsDeleted > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Customer Deleted Successfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Customer Delete Failed"
                    };
            }
            catch (Exception er)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = er.Message,
                    Message = "Customer Deletion Failed"
                };
            }
        }

    }
}
