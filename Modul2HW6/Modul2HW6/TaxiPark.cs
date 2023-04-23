using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6
{
    internal class TaxiPark
    {
        private Vehicle[] _vehicles = Array.Empty<Vehicle>();
        public void AddVehicle(Vehicle vehicle)
        {
            var length = _vehicles.Length;
            Array.Resize(ref _vehicles, newSize: length + 1);
            _vehicles[length] = vehicle;
        }

        public Vehicle[] GetVehicles()
        {
            return _vehicles;
        }
    }
}
