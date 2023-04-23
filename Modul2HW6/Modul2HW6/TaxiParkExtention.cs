using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6
{
    internal static class TaxiParkExtention
    {
        internal static Vehicle[] VehicleFitedByPrice(this TaxiPark vehicles, int minhP, int maxhP)
        {
            Vehicle[] foundedVehicles = Array.Empty<Vehicle>();
            foreach (var vehicle in vehicles.GetVehicles())
            {
                var horsePowers = vehicle.HP;
                if (horsePowers > minhP && horsePowers < maxhP)
                {
                    Array.Resize(ref foundedVehicles, foundedVehicles.Count() + 1);
                    foundedVehicles[foundedVehicles.Count() - 1] = vehicle;
                }
            }

            return foundedVehicles;
        }
    }
}
