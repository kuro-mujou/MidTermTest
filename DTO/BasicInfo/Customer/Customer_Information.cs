using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BasicInfo.Customer
{
    public class Customer_Information
    {
        public Customer_Information()
        {
            Customer_Name = string.Empty;
            Customer_Email = string.Empty;
            Customer_Phone = string.Empty;
            Customer_Address = new Address();
        }
        public Customer_Information(string customer_Name, string customer_Email, string customer_Phone,Address customer_Address)
        {
            Customer_Name = customer_Name;
            Customer_Email = customer_Email;
            Customer_Phone = customer_Phone;
            Customer_Address = customer_Address;
        }

        public string Customer_Name { get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Phone { get; set; }
        public Address Customer_Address { get; set; }
    }
}
