using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    class Customer:Human
    {
        public static string dbcon()
        {
            string dbconn = "datasource=localhost;username=root;password=;database=hms";
            return dbconn;
        }
    }
}
