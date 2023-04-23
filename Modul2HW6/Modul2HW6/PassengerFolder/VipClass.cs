using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.PassengerFolder
{
    internal class VipClass : BusinessClass
    {
        public VipClass(string vehicleName, int consumption, int hP, int passengerCount, int vehicleCost)
            : base(vehicleName, consumption, hP, passengerCount, vehicleCost)
        {
        }

        public bool VipCard { get; set; } = true;
    }
}
