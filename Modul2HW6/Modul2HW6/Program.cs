using Modul2HW6.CargoFolder;

namespace Modul2HW6
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            var garage = new Garage().CreateGarage();
            var tempGarage = garage.GetVehicles();
            Console.WriteLine();
            Display(tempGarage);
            Array.Sort(tempGarage);
            Console.WriteLine();
            Console.WriteLine("Taxi Park sorted by consumption:");
            Console.WriteLine();
            Display(tempGarage);
            Console.WriteLine();
            Console.WriteLine("To sellect vehicles by Horse Powers range, enter min power value:");
            var tempMinHP = Console.ReadLine();
            var minHP = int.Parse(tempMinHP);
            Console.WriteLine();
            Console.WriteLine("enter max power value:");
            var tempMaxHP = Console.ReadLine();
            var maxHP = int.Parse(tempMaxHP);
            Console.WriteLine();
            var findVehicle = garage.VehicleFitedByPrice(minHP, maxHP);
            if (findVehicle.Count() > 0)
            {
                Display(findVehicle);
            }
            else
            {
                Console.WriteLine("No vihicles founded");
            }

            Console.WriteLine();
            var totalVehiclesCost = 0;
            foreach (var item in tempGarage)
            {
                totalVehiclesCost = totalVehiclesCost + item.VehicleCost;
            }

            Console.WriteLine("Total vihicles in garage cost:");
            Console.WriteLine(totalVehiclesCost.ToString() + "$");

            void Display(Vehicle[] temp)
            {
                foreach (var item in temp)
                {
                    if (item is CargoVehicle)
                    {
                        var cargoVehicle = (CargoVehicle)item;
                        Console.WriteLine($"{cargoVehicle.VehicleName}: consumption {cargoVehicle.Consumption.ToString()}L/100km Horse Powers " +
                            $"{cargoVehicle.HP.ToString()} Vehicle Cost {cargoVehicle.VehicleCost.ToString()}$ Passanger Count {cargoVehicle.PassengerCount.ToString()}" +
                            $" Max Cargo Load {cargoVehicle.MaxCargoWeight.ToString()}");
                    }
                    else if (item is PassengerVehicle)
                    {
                        var passengerVehicle = (PassengerVehicle)item;
                        Console.WriteLine($"{passengerVehicle.VehicleName}: consumption {passengerVehicle.Consumption.ToString()}L/100km Horse Powers " +
                            $"{passengerVehicle.HP.ToString()} Vehicle Cost {passengerVehicle.VehicleCost.ToString()}$ Passanger Count {passengerVehicle.PassengerCount.ToString()}");
                    }
                }
            }
        }
    }
}