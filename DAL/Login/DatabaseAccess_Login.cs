using DTO.Login;
using System;
using System.Data.SqlClient;


namespace DAL.Login
{
    public class DatabaseAccess_Login
    {
        public static int Login(Login_Account account)
        {
            SqlConnection conn = DatabaseHelper.MySqlConnection();
            String sqlDN = "select count(*) from Login_Account " +
                            "where Username = '" + account.UserName + "'" +
                            " and Password = '" + account.Password + "' ";
            return (int)DatabaseHelper.Scalar(sqlDN, conn);
        }
    }
}
