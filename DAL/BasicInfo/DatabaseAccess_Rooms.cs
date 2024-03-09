using DTO.BasicInfo.HotelRoom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.BasicInfo
{
    public class DatabaseAccess_Rooms
    {
        public static DataTable GetAllTable()
        {
            SqlConnection conn = DatabaseHelper.MySqlConnection();
            String sqlLoadData = "select * from Room_Information";
            return DatabaseHelper.LoadDataTable(sqlLoadData,conn);
        }
    }
}
