

namespace DTO.BasicInfo
{
    public class Address
    {
        public Address()
        {
            City = string.Empty;
            Country = string.Empty;
        }
        public Address(string city, string country)
        {
            City = city;
            Country = country;
        }
        public static Address StringToAddress(string address)
        {
            string[] splited = address.Split(',');
            return new Address(splited[0], splited[1]);
        }
        public override string ToString()
        {
            return City + "," + Country;
        }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
