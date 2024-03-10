using DAL.BasicInfo;
using DTO.BasicInfo.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BasicInfo
{
    public class Logic_Staff
    {
        public object CheckLogicGetStaffs()
        {
            return DatabaseAccess_Staff.GetAllTable();
        }
        public object CheckLogicSearchByStaff_ID(int ID)
        {
            return DatabaseAccess_Staff.SearchByStaff_ID(ID);
        }
        public object CheckLogicSearchByStaff_Name(string Name)
        {
            return DatabaseAccess_Staff.SearchByStaff_Name(Name);
        }
        public object CheckLogicSearchByStaff_Phone(string Phone)
        {
            return DatabaseAccess_Staff.SearchByStaff_Phone(Phone);
        }
        public object CheckLogicSearchByStaff_Email(string Email)
        {
            return DatabaseAccess_Staff.SearchByStaff_Email(Email);
        }
        public object CheckLogicSearchByStaff_Address(string Address)
        {
            return DatabaseAccess_Staff.SearchByStaff_Address(Address);
        }
        public object CheckLogicSearchByStaff_Gender(string Gender)
        {
            return DatabaseAccess_Staff.SearchByStaff_Gender(Gender);
        }
        public object CheckLogicSearchByStaff_Position(string Gender)
        {
            return DatabaseAccess_Staff.SearchByStaff_Position(Gender);
        }
        public object CheckLogicSearchByStaff_Salary(string Gender)
        {
            return DatabaseAccess_Staff.SearchByStaff_Salary(Gender);
        }
        public string CheckLogicAddRow(Staff_Information Staff_Information)
        {
            if (DatabaseAccess_Staff.AddRow(Staff_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string CheckLogicEditRow(Staff_Information Staff_Information)
        {
            if (DatabaseAccess_Staff.EditRow(Staff_Information) >= 1)
            {
                return "success";
            }
            else
            {
                return "fail";
            }
        }
        public string CheckLogicDeleteRow(Staff_Information Staff_Information)
        {
            if (DatabaseAccess_Staff.DeleteRow(Staff_Information) >= 1)
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
