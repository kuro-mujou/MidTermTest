

namespace DTO.BasicInfo.HotelRoom
{
    public class RoomManagement
    {
        public int ID {  get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public int Customer_ID {  get; set; }
        public int Number { get; set;}
        public RentalStatus Rental_Status { get; set; }
        public enum RentalStatus
        {
            Occupied,
            CheckedOut
        }
        public RoomManagement() 
        { 
            ID = 0;
            StartDay = string.Empty;
            EndDay = string.Empty;
            Customer_ID = 0;
            Number = 0;
        }
        public RoomManagement(int id, string startDay, string endDay, int customer_ID, int number, RentalStatus rental_Status)
        {
            ID = id;
            StartDay = startDay;
            EndDay = endDay;
            Customer_ID = customer_ID;
            Number = number;
            Rental_Status = rental_Status;
        }
        public RoomManagement(string startDay, string endDay, int customer_ID, int number)
        {
            StartDay = startDay;
            EndDay = endDay;
            Customer_ID = customer_ID;
            Number = number;
        }
        public RoomManagement(string startDay, string endDay, int customer_ID, int number, RentalStatus rental_Status)
        {
            StartDay = startDay;
            EndDay = endDay;
            Customer_ID = customer_ID;
            Number = number;
            Rental_Status = rental_Status;
        }
    }
}
