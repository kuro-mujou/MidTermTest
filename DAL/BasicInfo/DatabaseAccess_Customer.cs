using DTO.BasicInfo.HotelRoom;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.BasicInfo.Customer;
using DTO.BasicInfo;

namespace DAL.BasicInfo
{
    public class DatabaseAccess_Customer
    {
        private static SqlConnection conn = DatabaseHelper.MySqlConnection();
        public static DataTable GetAllTable()
        {
            String sqlLoadData = "select * from Customer_Information";
            return DatabaseHelper.LoadDataTable(sqlLoadData, conn);
        }
        public static int AddRow(Customer_Information Customer_Information)
        {
            String sqlInsert = "insert into Customer_Information " + "values('"
                                + Customer_Information.Customer_Identity + "','"
                                + Customer_Information.Customer_Name + "','"
                                + Customer_Information.Customer_Email + "','"
                                + Customer_Information.Customer_Phone + "','"
                                + Customer_Information.Customer_Address.ToString() + "','"
                                + Customer_Information.Customer_Gender + "')";
            return DatabaseHelper.Nonquery(sqlInsert, conn);
        }
        public static int EditRow(Customer_Information Customer_Information)
        {
            string sqlEdit = "update Customer_Information set Customer_Identity = '"
                + Customer_Information.Customer_Identity + "', Customer_Name = '"
                + Customer_Information.Customer_Name + "', Customer_Email = '"
                + Customer_Information.Customer_Email + "', Customer_Phone = '"
                + Customer_Information.Customer_Phone + "', Customer_Address = '"
                + Customer_Information.Customer_Address.ToString() + "', Gender = '"
                + Customer_Information.Customer_Gender + "' where Customer_ID = "
                + Customer_Information.Customer_ID + ";";
            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static int DeleteRow(Customer_Information Customer_Information)
        {
            string sqlEdit = "delete from Customer_Information where Customer_ID = " + Customer_Information.Customer_ID;

            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static DataTable SearchByCustomer_ID(int ID)
        {
            string sqlSearchStatus = "select * from Customer_Information where Customer_ID = '" + ID + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static DataTable SearchByCustomer_Identity(int ID)
        {
            string sqlSearchStatus = "select * from Customer_Information where Customer_Identity = '" + ID + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static object SearchByCustomer_Name(string name)
        {
            string sqlSearchStatus = "select * from Customer_Information where Customer_Name = '" + name + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static object SearchByCustomer_Email(string email)
        {
            string sqlSearchStatus = "select * from Customer_Information where Customer_Email = '" + email + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByCustomer_Phone(string phone)
        {
            string sqlSearchStatus = "select * from Customer_Information where Customer_Phone = '" + phone + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByCustomer_Address(string adress)
        {
            string sqlSearchStatus = "select * from Customer_Information where Customer_Address = '" + adress + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByCustomer_Gender(string gender)
        {
            string sqlSearchStatus = "select * from Customer_Information where Gender = '" + gender + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static Customer_Information GetCustomer_Information(int customerId)
        {
            string sqlSearch = "select * from Customer_Information where Customer_ID = '" + customerId + "'";
            SqlDataReader reader = DatabaseHelper.GetOneRow(sqlSearch, conn);
            if (reader.Read())
            {
                int Customer_ID = reader.GetInt32(0);
                int Customer_Identity = reader.GetInt32(1);
                string Customer_Name = reader.GetString(2);
                string Customer_Gender = reader.GetString(3);
                string Customer_Email = reader.GetString(4);
                string Customer_Phone = reader.GetString(5);
                string Customer_Address = reader.GetString(6);
                return new Customer_Information(Customer_ID,Customer_Identity,Customer_Name,Customer_Gender,Customer_Email,Customer_Phone,Address.StringToAddress(Customer_Address));
            }
            else
            {
                return null;
            }
        }
    }
}
