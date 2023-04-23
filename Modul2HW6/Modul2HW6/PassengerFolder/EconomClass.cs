using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.PassengerFolder
{
    internal class EconomClass : PassengerVehicle
    {
        public EconomClass(string vehicleName, int consumption, int hP, int passengerCount, int vehicleCost)
        {
            VehicleName = vehicleName;
            Consumption = consumption;
            HP = hP;
            PassengerCount = passengerCount;
            VehicleCost = vehicleCost;
        }

        public bool TaxMetr { get; set; } = true;
        public override string Drive()
        {
            return "Driving with passangers";
        }
    }
}
