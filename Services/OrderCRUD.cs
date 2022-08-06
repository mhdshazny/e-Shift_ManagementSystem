using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace e_Shift_ManagementSystem.Services
{
    class OrderCRUD
    {
        public OrderCRUD(int cusID, string orderItem, string orderDescription, string status)
        {
            CusID = cusID;
            OrderItem = orderItem;
            OrderDescription = orderDescription;
            Status = status;
        }

        public OrderCRUD()
        {
        }

        private int OrderID { get; set; }
        private int CusID { get; set; }
        private string OrderItem { get; set; }
        private string OrderDescription { get; set; }
        private string Status { get; set; }


        SqlConnection con = new SqlConnection(@"Data Source=mhd-shazny;Initial Catalog=eshiftDb;Integrated Security=True");

        public DataTable GetAll()
        {
            string query = "select * from Tbl_Order INNER JOIN TBL_Customer ON Tbl_Order.CusID = TBL_Customer.Id";

            SqlCommand com = new SqlCommand(query,con);

            con.Open();


            SqlDataAdapter da = new SqlDataAdapter(com);
            

            DataTable dt = new DataTable();

            da.Fill(dt);
      
            con.Close();
            return dt;


        }

        public List<string> GetCustomerList()
        {
            List<string> li = new List<string>();


            string query = "select Id, CusEmail from Tbl_customer";

            SqlCommand com = new SqlCommand(query, con);

            con.Open();




            SqlDataAdapter da = new SqlDataAdapter(com);


            DataTable dt = new DataTable();

            da.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {
                li.Add(item[0].ToString());
            }


            con.Close();
            return li;
        }

        public Returns InsertOrder()
        {
            try
            {
                string query = "INSERT INTO Tbl_Order(CusID,OrderItem,OrderDescription," +
                            "Status) VALUES('" + CusID + "','" + OrderItem + "'," +
                            "'" + OrderDescription + "','" + Status + "')";
                SqlCommand com = new SqlCommand(query, con);
                con.Open();
                int rowsAdded = com.ExecuteNonQuery();
                if (rowsAdded > 0)
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = true,
                        ErrorMessage = string.Empty,
                        Message = "Order Added Successfully"
                    };
                else
                    return new Returns
                    {
                        ID = 0,
                        IsSuccess = false,
                        ErrorMessage = string.Empty,
                        Message = "Order Registration Failed"
                    };
            }
            catch (Exception error)
            {
                return new Returns
                {
                    ID = 0,
                    IsSuccess = false,
                    ErrorMessage = error.Message,
                    Message = "Order Registration Failed"
                };
            }
            finally
            {
                con.Close();
            }
        }


    }
}
