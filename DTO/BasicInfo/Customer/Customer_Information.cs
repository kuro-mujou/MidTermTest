

namespace DTO.BasicInfo.Customer
{
    public class Customer_Information
    {
        public Customer_Information()
        {
            Customer_ID = 0;
            Customer_Identity = 0;
            Customer_Name = string.Empty;
            Customer_Email = string.Empty;
            Customer_Phone = string.Empty;
            Customer_Address = new Address();
        }
        public Customer_Information(int customer_ID, int customer_Identity, string customer_Name, string customer_gender, string customer_Email, string customer_Phone,Address customer_Address)
        {
            Customer_ID = customer_ID;
            Customer_Identity = customer_Identity;
            Customer_Name = customer_Name;
            Customer_Gender = customer_gender;
            Customer_Email = customer_Email;
            Customer_Phone = customer_Phone;
            Customer_Address = customer_Address;
        }
        public Customer_Information(int customer_Identity, string customer_Name, string customer_gender, string customer_Email, string customer_Phone, Address customer_Address)
        {
            Customer_Identity = customer_Identity;
            Customer_Name = customer_Name;
            Customer_Gender = customer_gender;
            Customer_Email = customer_Email;
            Customer_Phone = customer_Phone;
            Customer_Address = customer_Address;
        }

        public int Customer_ID { get; set; }
        public int Customer_Identity {  get; set; }
        public string Customer_Name { get; set; }
        public string Customer_Gender {  get; set; }
        public string Customer_Email { get; set; }
        public string Customer_Phone { get; set; }
        public Address Customer_Address { get; set; }
    }
}
