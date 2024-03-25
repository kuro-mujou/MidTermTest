using DTO.BasicInfo.HotelRoom;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL.BasicInfo
{
    public class DatabaseAccess_Rental
    {
        private static SqlConnection conn = DatabaseHelper.MySqlConnection();
        public static DataTable GetAllTable()
        {
            String sqlLoadData = "select * from Room_Management";
            return DatabaseHelper.LoadDataTable(sqlLoadData, conn);
        }
        public static int AddRow(RoomManagement RoomManagement)
        {
            String sqlInsert = "insert into Room_Management " + "values('"
                                + RoomManagement.StartDay + "','"
                                + RoomManagement.EndDay + "','"
                                + RoomManagement.Customer_ID + "','"
                                + RoomManagement.Number + "','"
                                + RoomManagement.Rental_Status + "')";
            return DatabaseHelper.Nonquery(sqlInsert, conn);
        }
        public static int EditRow(RoomManagement RoomManagement)
        {
            string sqlEdit = "update Room_Management set StartDay = '"
                + RoomManagement.StartDay + "', EndDay = '"
                + RoomManagement.EndDay + "', Customer_ID = '"
                + RoomManagement.Customer_ID + "', Number = '"
                + RoomManagement.Number + "', Rental_Status = '"
                + RoomManagement.Rental_Status + "' where Id = "
                + RoomManagement.ID + ";";
            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static int DeleteRow(RoomManagement RoomManagement)
        {
            string sqlEdit = "delete from Room_Management where Id = " + RoomManagement.ID;
            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static RoomManagement GetOneRowByID(int ID)
        {
            string sqlSearch = "select * from Room_Management where Customer_ID = '" + ID + "'";
            SqlDataReader reader = DatabaseHelper.GetOneRow(sqlSearch, conn);
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                string startday = reader.GetString(1);
                string endday = reader.GetString(2);
                int customerID = reader.GetInt32(3);
                int roomNumber = reader.GetInt32(4);
                string status = reader.GetString(5);
                RoomManagement.RentalStatus rentalStatus = (RoomManagement.RentalStatus)Enum.Parse(typeof(RoomManagement.RentalStatus), status);
                conn.Close();
                return new RoomManagement(id, startday, endday, customerID, roomNumber, rentalStatus);
            }
            else
            {
                conn.Close();
                return null;
            }
        }
        public static DataTable SearchByCustomer_Identity(int ID)
        {
            string sqlSearchStatus = "select * from Room_Management where Customer_ID = '" + ID + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static DataTable SearchByRoom_Number(int Number)
        {
            string sqlSearchStatus = "select * from Room_Management where Number = '" + Number + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static object SearchByID(int id)
        {
            string sqlSearch = "select * from Room_Management where Id = '" + id + "'";
            return DatabaseHelper.LoadDataTable(sqlSearch, conn);
        }

        public static object SearchByStartDay(string startDay)
        {
            string sqlSearch = "select * from Room_Management where StartDay = '" + startDay + "'";
            return DatabaseHelper.LoadDataTable(sqlSearch, conn);
        }

        public static object SearchByEndDay(string EndDay)
        {
            string sqlSearch = "select * from Room_Management where EndDay = '" + EndDay + "'";
            return DatabaseHelper.LoadDataTable(sqlSearch, conn);
        }

        public static object SearchByStatus(string status)
        {
            string sqlSearch = "select * from Room_Management where RentalStatus = '" + status + "'";
            return DatabaseHelper.LoadDataTable(sqlSearch, conn);
        }

        //public static object SearchByCustomer_Name(string name)
        //{
        //   
        //}

        //public static object SearchByCustomer_Email(string email)
        //{
        //    string sqlSearchStatus = "select * from RoomManagement where Customer_Email = '" + email + "'";
        //    return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        //}
        //public static object SearchByCustomer_Phone(string phone)
        //{
        //    string sqlSearchStatus = "select * from RoomManagement where Customer_Phone = '" + phone + "'";
        //    return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        //}
        //public static object SearchByCustomer_Address(string adress)
        //{
        //    string sqlSearchStatus = "select * from RoomManagement where Customer_Address = '" + adress + "'";
        //    return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        //}
        //public static object SearchByCustomer_Gender(string gender)
        //{
        //    string sqlSearchStatus = "select * from RoomManagement where Gender = '" + gender + "'";
        //    return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        //}
    }
}
