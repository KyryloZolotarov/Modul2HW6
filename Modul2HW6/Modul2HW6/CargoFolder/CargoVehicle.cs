using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.CargoFolder
{
    internal abstract class CargoVehicle : PassengerVehicle
    {
        public int MaxCargoWeight { get; set; }
    }
}
