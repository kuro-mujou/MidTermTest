using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Login
{
    public class Login_Account
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Login_Account() 
        { 
            UserName = string.Empty;
            Password = string.Empty;
        }
        public Login_Account(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
