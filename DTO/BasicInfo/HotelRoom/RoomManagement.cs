using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BasicInfo.HotelRoom
{
    public class RoomManagement
    {
        public int ID {  get; set; }
        public string StartDay { get; set; }
        public string EndDay { get; set; }
        public int Customer_ID {  get; set; }
        public int Number { get; set;}
        public RoomManagement() 
        { 
            ID = 0;
            StartDay = string.Empty;
            EndDay = string.Empty;
            Customer_ID = 0;
            Number = 0;
        }
        public RoomManagement(int iD, string startDay, string endDay, int customer_ID, int number)
        {
            ID = iD;
            StartDay = startDay;
            EndDay = endDay;
            Customer_ID = customer_ID;
            Number = number;
        }
    }
}
