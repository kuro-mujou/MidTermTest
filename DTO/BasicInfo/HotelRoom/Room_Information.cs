

namespace DTO.BasicInfo.HotelRoom
{
    public class Room_Information
    {

        public int Number { get; set; }
        public Room_Type RoomType { get; set; }
        public Room_Status Status { get; set; }

        public enum Room_Status
        {
            EMPTY,
            OCCUPIED,
            CLEANING
        }

        public enum Room_Type
        {
            Empty,
            Standard_Room1,
            Standard_Room2,
            Deluxe_Room,
            Executive_Room
        }
        //Standard Room:
        //A basic room with essential amenities suitable for individual travelers or couples.
        //Have 1/2 bed

        //Deluxe Room:
        //A larger room with upgraded amenities and possibly better views.
        //Have 2 bed with more furniture

        //Executive Room:
        //A room designed for business travelers, often featuring additional workspace and amenities.
        //Have 1 bed and workspace
        public Room_Information()
        {
            Number = 0;
            RoomType = Room_Type.Standard_Room1;
            Status = Room_Status.EMPTY;
        }
        public Room_Information(int number, Room_Type type, Room_Status status)
        {
            Number = number;
            RoomType = type;
            Status = status;
        }
    }
}
