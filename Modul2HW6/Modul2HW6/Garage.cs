using Modul2HW6.CargoFolder;
using Modul2HW6.PassengerFolder;

namespace Modul2HW6
{
    internal class Garage
    {
        public TaxiPark CreateGarage()
        {
            var vehicles = new TaxiPark();
            var count = new GeneratorRandom().Rand(0, 10);
            for (var i = 0; i < count; i++)
            {
                VehicleConstructor("Minivan", out int consumption, out int hP, out int passengerCount, out int vehicleCost);
                RandomCargoWeight(800, 1000, out int maxCargoWeight);
                string vehicleName = "Minivan " + (i + 1).ToString();
                Minivan minivan = new Minivan(vehicleName, maxCargoWeight, consumption, hP, passengerCount, vehicleCost);
                vehicles.AddVehicle(minivan);
            }

            count = new GeneratorRandom().Rand(0, 10);
            for (var i = 0; i < count; i++)
            {
                VehicleConstructor("Truck", out int consumption, out int hP, out int passengerCount, out int vehicleCost);
                RandomCargoWeight(500, 1500, out int maxCargoWeight);
                bool trailerConnected;
                var rand = new GeneratorRandom().Rand(0, 2);
                if (rand == 0)
                {
                    trailerConnected = false;
                }
                else
                {
                    trailerConnected = true;
                }

                string vehicleName = "Truck " + (i + 1).ToString();
                Truck truck = new Truck(vehicleName, maxCargoWeight, consumption, hP, passengerCount, vehicleCost, trailerConnected);
                vehicles.AddVehicle(truck);
            }

            count = new GeneratorRandom().Rand(0, 10);
            for (var i = 0; i < count; i++)
            {
                VehicleConstructor("EconomClass", out int consumption, out int hP, out int passengerCount, out int vehicleCost);
                string vehicleName = "EconomClass Car " + (i + 1).ToString();
                EconomClass economClass = new EconomClass(vehicleName, consumption, hP, passengerCount, vehicleCost);
                vehicles.AddVehicle(economClass);
            }

            count = new GeneratorRandom().Rand(0, 10);
            for (var i = 0; i < count; i++)
            {
                VehicleConstructor("BusinessClass", out int consumption, out int hP, out int passengerCount, out int vehicleCost);
                string vehicleName = "BusinessClass Car " + (i + 1).ToString();
                BusinessClass businessClass = new BusinessClass(vehicleName, consumption, hP, passengerCount, vehicleCost);
                vehicles.AddVehicle(businessClass);
            }

            count = new GeneratorRandom().Rand(0, 10);
            for (var i = 0; i < count; i++)
            {
                VehicleConstructor("VipClass", out int consumption, out int hP, out int passengerCount, out int vehicleCost);
                string vehicleName = "VipClass Car " + (i + 1).ToString();
                VipClass vipClass = new VipClass(vehicleName, consumption, hP, passengerCount, vehicleCost);
                vehicles.AddVehicle(vipClass);
            }

            return vehicles;
        }

        public void VehicleConstructor(string vehicletype, out int consumption, out int hP, out int passengerCount, out int vehicleCost)
        {
            switch (vehicletype)
            {
                case "Minivan":
                    RandHP(100, 200, out hP);
                    RandConsumption(7, 20, out consumption);
                    RandomPassengerCount(0, 8, out passengerCount);
                    RandomVehicleCost(6000, 15000, out vehicleCost);
                    break;
                case "Truck":
                    RandHP(200, 400, out hP);
                    RandConsumption(16, 35, out consumption);
                    RandomPassengerCount(0, 4, out passengerCount);
                    RandomVehicleCost(10000, 25000, out vehicleCost);
                    break;
                case "EconomClass":
                    RandHP(50, 150, out hP);
                    RandConsumption(5, 12, out consumption);
                    RandomPassengerCount(0, 5, out passengerCount);
                    RandomVehicleCost(3000, 9000, out vehicleCost);
                    break;
                case "BusinessClass":
                    RandHP(100, 400, out hP);
                    RandConsumption(10, 17, out consumption);
                    RandomPassengerCount(0, 5, out passengerCount);
                    RandomVehicleCost(10000, 20000, out vehicleCost);
                    break;
                case "VipClass":
                    RandHP(100, 400, out hP);
                    RandConsumption(10, 17, out consumption);
                    RandomPassengerCount(0, 5, out passengerCount);
                    RandomVehicleCost(20000, 50000, out vehicleCost);
                    break;
                default:
                    consumption = 0;
                    hP = 0;
                    passengerCount = 0;
                    vehicleCost = 0;
                    Console.WriteLine("Error");
                    break;
            }
        }

        public void RandHP(int minhp,  int maxhp, out int hp)
        {
            hp = new GeneratorRandom().Rand(minhp, maxhp);
        }

        public void RandConsumption(int minconsumption, int maxconsumption, out int consumption)
        {
            consumption = new GeneratorRandom().Rand(minconsumption, maxconsumption);
        }

        public void RandomCargoWeight(int minCargoweight, int maxCargoweight, out int cargoweight)
        {
            cargoweight = new GeneratorRandom().Rand(minCargoweight, maxCargoweight);
        }

        public void RandomPassengerCount(int minPassengerCount, int maxPassengerCOunt, out int passengercount)
        {
            passengercount = new GeneratorRandom().Rand(minPassengerCount, maxPassengerCOunt);
        }

        public void RandomVehicleCost(int minVihicleCost, int maxVihicleCost, out int vihicleCost)
        {
            vihicleCost = new GeneratorRandom().Rand(minVihicleCost, maxVihicleCost);
        }
    }
}
