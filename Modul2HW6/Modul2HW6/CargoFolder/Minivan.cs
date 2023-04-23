using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.CargoFolder
{
    internal class Minivan : CargoVehicle
    {
        public Minivan(string vehicleName, int maxCargoWeight, int consumption, int hP, int passengerCount, int vehicleCost)
        {
            VehicleName = vehicleName;
            Consumption = consumption;
            HP = hP;
            PassengerCount = passengerCount;
            MaxCargoWeight = maxCargoWeight - (passengerCount * 100);
            VehicleCost = vehicleCost;
        }

        public bool Tachograph { get; set; } = true;

        public override string Drive()
        {
            return "Driving with passengers and cargo";
        }
    }
}
