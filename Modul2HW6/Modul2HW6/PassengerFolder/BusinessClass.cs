using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.PassengerFolder
{
    internal class BusinessClass : EconomClass
    {
        public BusinessClass(string vehicleName, int consumption, int hP, int passengerCount, int vehicleCost)
            : base(vehicleName, consumption, hP, passengerCount, vehicleCost)
        {
        }

        public bool AirConditioner { get; set; } = true;
        public bool LetherSits { get; set; } = true;
        public override string Drive()
        {
            return "Driving with passangers";
        }
    }
}
