using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW6.CargoFolder
{
    internal class Truck : Minivan
    {
        public Truck(string vehicleName, int maxCargoWeight, int consumption, int hP, int passengerCount, int vehicleCost, bool isTrailerConncted)
            : base(vehicleName, maxCargoWeight, consumption, hP, passengerCount, vehicleCost)
        {
            IsTrailerConncted = isTrailerConncted;
            if (IsTrailerConncted == true)
            {
                MaxCargoWeight = maxCargoWeight + Trailer.TrailerMaxLoad;
            }
        }

        public bool IsTrailerConncted { get; set; }
        public Trailers Trailer { get; set; } = new Trailers();
        internal class Trailers
        {
            public int TrailerMaxLoad { get; set; } = 1500;
        }
    }
}
