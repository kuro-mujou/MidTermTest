using DAL.Login;
using DTO.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Login
{
    public class Logic_Login
    {
        public string CheckLogicLogin(Login_Account login_Account)
        {
            if(login_Account.UserName == "")
            {
                return "require username";
            }
            if(login_Account.Password == "")
            {
                return "require password";
            }    
            if(DatabaseAccess_Login.Login(login_Account) >= 1)
            {
                return "success";
            } 
            else
            {
                return "no account found";
            }
        }
    }
}
