using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseHelper
    {
        //public static string ConnectionString => ConfigurationManager.ConnectionStrings["DAL.Properties.Settings.DatabaseConnectionString"].ConnectionString;
        public static SqlConnection MySqlConnection()
        {
            string ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\PC\source\repos\MidTermTest\DAL\Database.mdf; Integrated Security = True";
            SqlConnection conn = new SqlConnection(ConnectionString);
            return conn;
        }
        public static Object Scalar(String sqlScalar,SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int DataSet = (int)comm.ExecuteScalar();
            conn.Close();
            return DataSet;
        }
        public static DataTable LoadDataTable(String sqlDL, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sqlDL, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static int Nonquery(String sqlNon, SqlConnection conn)
        {
            SqlCommand comm = new SqlCommand(sqlNon, conn);
            conn.Open();
            //try
            //{
                return comm.ExecuteNonQuery();
            //}
            //catch (SqlException)
            //{
            //    return 0;
            //}
            //finally
            //{
            //    conn.Close();
            //}
        }
    }
}
