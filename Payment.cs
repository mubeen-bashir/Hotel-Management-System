using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    class Payment
    {
        public int roomcharges;
        public int rescharges;
        public int sercharges;
        public int totalcharg;
        public int paymentcal()
        {
            totalcharg = (roomcharges + rescharges + sercharges);
            return totalcharg;
        }
    }
}
