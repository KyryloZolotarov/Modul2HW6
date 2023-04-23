using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6
{
    internal abstract class Vehicle : IEngine, IComparable
    {
        public string? VehicleName { get; set; }
        public int VehicleCost { get; set; }
        public int Consumption { get; set; }
        public int HP { get; set; }
        public abstract string Drive();
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            Vehicle? otherVehicle = obj as Vehicle;
            if (otherVehicle != null)
            {
                return this.Consumption.CompareTo(otherVehicle.Consumption);
            }
            else
            {
                throw new ArgumentException("Object is not a Vehicle");
            }
        }
    }
}
