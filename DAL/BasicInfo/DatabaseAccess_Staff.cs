using DTO.BasicInfo.Staff;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BasicInfo
{
    public class DatabaseAccess_Staff
    {
        private static SqlConnection conn = DatabaseHelper.MySqlConnection();
        public static DataTable GetAllTable()
        {
            String sqlLoadData = "select * from Staff_Information";
            return DatabaseHelper.LoadDataTable(sqlLoadData, conn);
        }
        public static int AddRow(Staff_Information Staff_Information)
        {
            String sqlInsert = "insert into Staff_Information " + "values('"
                                + Staff_Information.Staff_Name + "','"
                                + Staff_Information.Staff_Gender + "','"
                                + Staff_Information.Staff_Email + "','"
                                + Staff_Information.Staff_Phone + "','"
                                + Staff_Information.Staff_Address.ToString() + "','"
                                + Staff_Information.Staff_Position + "','"
                                + Staff_Information.Staff_Salary + "')";
            return DatabaseHelper.Nonquery(sqlInsert, conn);
        }
        public static int EditRow(Staff_Information Staff_Information)
        {
            string sqlEdit = "update Staff_Information set Staff_Name = '"
                + Staff_Information.Staff_Name + "', Staff_Gender = '"
                + Staff_Information.Staff_Gender + "', Staff_Email = '"
                + Staff_Information.Staff_Email + "', Staff_Phone = '"
                + Staff_Information.Staff_Phone + "', Staff_Address = '"
                + Staff_Information.Staff_Address.ToString() + "', Staff_Position = '"
                + Staff_Information.Staff_Position + "', Staff_Salary = '"
                + Staff_Information.Staff_Salary + "' where Staff_ID = "
                + Staff_Information.Staff_ID + ";";
            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static int DeleteRow(Staff_Information Staff_Information)
        {
            string sqlEdit = "delete from Staff_Information where Staff_ID = " + Staff_Information.Staff_ID;

            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static DataTable SearchByStaff_ID(int ID)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_ID = '" + ID + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static object SearchByStaff_Name(string name)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Name = '" + name + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByStaff_Gender(string gender)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Gender = '" + gender + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByStaff_Email(string email)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Email = '" + email + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByStaff_Phone(string phone)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Phone = '" + phone + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByStaff_Address(string adress)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Address = '" + adress + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByStaff_Position(string position)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Position = '" + position + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
        public static object SearchByStaff_Salary(string salary)
        {
            string sqlSearchStatus = "select * from Staff_Information where Staff_Salary = '" + salary + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }
    }
}
