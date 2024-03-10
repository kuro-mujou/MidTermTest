using DTO.BasicInfo.HotelRoom;
using DAL.BasicInfo;
using DTO.BasicInfo.Customer;

namespace BLL.BasicInfo
{
    public class Logic_Rental
    {
        public string CheckLogicAddRow(RoomManagement roomManagement)
        {
            if (DatabaseAccess_Rental.AddRow(roomManagement) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        public string CheckLogicDeleteRow(RoomManagement roomManagement)
        {
            if (DatabaseAccess_Rental.DeleteRow(DatabaseAccess_Rental.GetOneRowByID(roomManagement.Customer_ID)) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        public string CheckLogicEditRow(RoomManagement roomManagement)
        {
            if (DatabaseAccess_Rental.EditRow(DatabaseAccess_Rental.GetOneRowByID(roomManagement.Customer_ID)) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }

        public object CheckLogicGetRentals()
        {
            return DatabaseAccess_Rental.GetAllTable();
        }
        public object CheckLogicSearchByCustomerIdentity(int id)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Identity(id);
        }
        public object CheckLogicSearchByRoomNumber(int number)
        {
            return DatabaseAccess_Rooms.SearchByNumber(number);
        }
        public object CheckLogicSearchByCustomer_Identity(int id)
        {
            return DatabaseAccess_Rental.SearchByCustomer_Identity(id);
        }
        public object CheckLogicSearchByRoom_Number(int number)
        {
            return DatabaseAccess_Rental.SearchByRoom_Number(number);
        }
        public object CheckLogicSearchByID(int id)
        {
            return DatabaseAccess_Rental.SearchByID(id);
        }
        public object CheckLogicSearchByStartDay(string StartDay)
        {
            return DatabaseAccess_Rental.SearchByStartDay(StartDay);
        }
        public object CheckLogicSearchByEndDay(string EndDay)
        {
            return DatabaseAccess_Rental.SearchByEndDay(EndDay);
        }
        public object CheckLogicSearchByRentalStatus(string Status)
        {
            return DatabaseAccess_Rental.SearchByStatus(Status);
        }
        public Customer_Information GetCustomer_Information(int id)
        {
            return DatabaseAccess_Customer.GetCustomer_Information(id);
        }
        public Room_Information GetRoom_Information(int number)
        {
            return DatabaseAccess_Rooms.GetRoom_Information(number);
        }
    }
}
