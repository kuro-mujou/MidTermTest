using DAL.BasicInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BasicInfo
{
    public class Logic_Rooms
    {
        public object CheckLogicRooms()
        {
            return DatabaseAccess_Rooms.GetAllTable();
        }
    }
}
