using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.BasicInfo.Staff
{
    public class Staff_Information
    {
        public Staff_Information()
        {
            Staff_ID = 0;
            Staff_Name = string.Empty;
            Staff_Gender = string.Empty;
            Staff_Email = string.Empty;
            Staff_Phone = string.Empty;
            Staff_Address = new Address();
            Staff_Position = string.Empty;
            Staff_Salary = string.Empty;
        }
        public Staff_Information(string staff_Name, string staff_Gender, string staff_Email, string staff_Phone, Address staff_Address, string staff_Position, string staff_Salary)
        {
            Staff_Name = staff_Name;
            Staff_Gender = staff_Gender;
            Staff_Email = staff_Email;
            Staff_Phone = staff_Phone;
            Staff_Address = staff_Address;
            Staff_Position = staff_Position;
            Staff_Salary = staff_Salary;
        }
        public Staff_Information(int staff_ID,string staff_Name, string staff_Gender, string staff_Email, string staff_Phone, Address staff_Address, string staff_Position, string staff_Salary)
        {
            Staff_ID = staff_ID;
            Staff_Name = staff_Name;
            Staff_Gender = staff_Gender;
            Staff_Email = staff_Email;
            Staff_Phone = staff_Phone;
            Staff_Address = staff_Address;
            Staff_Position = staff_Position;
            Staff_Salary = staff_Salary;
        }

        public int Staff_ID {  get; set; }
        public string Staff_Name { get; set; }
        public string Staff_Gender {  get; set; }
        public string Staff_Email { get; set; }
        public string Staff_Phone { get; set; }
        public Address Staff_Address { get; set; }
        public string Staff_Position { get; set; }
        public string Staff_Salary { get; set; }
    }
}
