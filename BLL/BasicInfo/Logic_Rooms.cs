using DAL.BasicInfo;
using DAL.Login;
using DTO.BasicInfo.HotelRoom;
using DTO.Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BasicInfo
{
    public class Logic_Rooms
    {
        public object CheckLogicGetRooms()
        {
            return DatabaseAccess_Rooms.GetAllTable();
        }
        public object CheckLogicSeachByStatus(string status)
        {
            return DatabaseAccess_Rooms.SearchByStatus(status);
        }
        public object CheckLogicSeachByRoomType(string roomType)
        {
            return DatabaseAccess_Rooms.SearchByRoomType(roomType);
        }
        public string CheckLogicAddRow(Room_Information room_Information)
        {
            if (DatabaseAccess_Rooms.AddRow(room_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string CheckLogicEditRow(Room_Information room_Information)
        {
            if (DatabaseAccess_Rooms.EditRow(room_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string CheckLogicDeleteRow(Room_Information room_Information)
        {
            if (DatabaseAccess_Rooms.DeleteRow(room_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

    }
}
