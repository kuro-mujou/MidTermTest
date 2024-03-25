using DTO.BasicInfo.Customer;
using DTO.BasicInfo;
using DTO.BasicInfo.HotelRoom;
using System;
using System.Data;
using System.Data.SqlClient;
using static DTO.BasicInfo.HotelRoom.Room_Information;

namespace DAL.BasicInfo
{
    public class DatabaseAccess_Rooms
    {
        private static SqlConnection conn = DatabaseHelper.MySqlConnection();
        public static DataTable GetAllTable()
        {
            String sqlLoadData = "select * from Room_Information";
            return DatabaseHelper.LoadDataTable(sqlLoadData,conn);
        }
        public static int AddRow(Room_Information room_Information) 
        {
            String sqlInsert =    "insert into Room_Information " + "values('" 
                                + room_Information.Number + "','" 
                                + room_Information.RoomType + "','" 
                                + room_Information.Status + "')";
            return DatabaseHelper.Nonquery(sqlInsert, conn);
        }
        public static int EditRow(Room_Information room_Information)
        {
            string sqlEdit = "update Room_Information set RoomType = '" 
                + room_Information.RoomType.ToString() + "', Status = '" 
                + room_Information.Status.ToString() + "' where Number = "
                + room_Information.Number + ";";
            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }
        public static int DeleteRow(Room_Information room_Information)
        {
            string sqlEdit = "delete from Room_Information where Number = " + room_Information.Number;

            return DatabaseHelper.Nonquery(sqlEdit, conn);
        }

        public static DataTable SearchByStatus(string status)
        {
            string sqlSearchStatus = "select * from Room_Information where Status = '" + status + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static object SearchByRoomType(string roomType)
        {
            string sqlSearchStatus = "select * from Room_Information where RoomType = '" + roomType + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static object SearchByNumber(int roomNumber)
        {
            string sqlSearchStatus = "select * from Room_Information where Number = '" + roomNumber + "'";
            return DatabaseHelper.LoadDataTable(sqlSearchStatus, conn);
        }

        public static Room_Information GetRoom_Information(int number)
        {
            string sqlSearch = "select * from Room_Information where Number = " + number;
            SqlDataReader reader = DatabaseHelper.GetOneRow(sqlSearch, conn);
            if (reader.Read())
            {
                int Number = reader.GetInt32(0);
                string RoomType = reader.GetString(1);
                string Status = reader.GetString(2);
                Room_Information.Room_Type room_Type = (Room_Information.Room_Type)Enum.Parse(typeof(Room_Information.Room_Type), RoomType);
                Room_Information.Room_Status room_Status = (Room_Information.Room_Status)Enum.Parse(typeof(Room_Information.Room_Status), Status);
                conn.Close();
                return new Room_Information(Number, room_Type, room_Status);
            }
            else
            {
                conn.Close();
                return null;
            }
        }
    }
}
