using DAL.BasicInfo;
using DTO.BasicInfo.Customer;

namespace BLL.BasicInfo
{
    public class Logic_Customers
    {
        public object CheckLogicGetCustomers()
        {
            return DatabaseAccess_Customer.GetAllTable();
        }
        public object CheckLogicSearchByCustomer_ID(int ID)
        {
            return DatabaseAccess_Customer.SearchByCustomer_ID(ID);
        }
        public object CheckLogicSearchByCustomer_Identity(int ID)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Identity(ID);
        }
        public object CheckLogicSearchByCustomer_Name(string Name)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Name(Name);
        }
        public object CheckLogicSearchByCustomer_Phone(string Phone)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Phone(Phone);
        }
        public object CheckLogicSearchByCustomer_Email(string Email)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Email(Email);
        }
        public object CheckLogicSearchByCustomer_Address(string Address)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Address(Address);
        }
        public object CheckLogicSearchByCustomer_Gender(string Gender)
        {
            return DatabaseAccess_Customer.SearchByCustomer_Gender(Gender);
        }
        public string CheckLogicAddRow(Customer_Information Customer_Information)
        {
            if (DatabaseAccess_Customer.AddRow(Customer_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string CheckLogicEditRow(Customer_Information Customer_Information)
        {
            if (DatabaseAccess_Customer.EditRow(Customer_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string CheckLogicDeleteRow(Customer_Information Customer_Information)
        {
            if (DatabaseAccess_Customer.DeleteRow(Customer_Information) >= 1)
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
