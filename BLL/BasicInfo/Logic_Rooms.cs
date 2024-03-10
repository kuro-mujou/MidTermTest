using DAL.BasicInfo;
using DTO.BasicInfo.HotelRoom;

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
        public object CheckLogicSeachByRoomNumber(int roomNumber)
        {
            return DatabaseAccess_Rooms.SearchByNumber(roomNumber);
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
