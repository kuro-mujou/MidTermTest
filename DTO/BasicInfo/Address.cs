using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BasicInfo
{
    public class Address
    {
        public Address()
        {
            Street = string.Empty;
            City = string.Empty;
            Country = string.Empty;
        }
        public Address(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }
        public override string ToString()
        {
            return Street + " " + City + " " + Country;
        }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
