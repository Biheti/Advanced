using Homework03Advanced.Vehicles;

namespace Homework03Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car { Id = 1, Type = "Sedan", CountriesProduced = new List<string> { "USA", "Germany" } };
            Bike bike1 = new Bike { Id = 2, YearOfProduction = 2022, Color = "Red" };
            Vehicle vehicle1 = new Vehicle { Id = 3, Type = "Unknown", YearOfProduction = 2000 };

            VehicleDB.Vehicles.Add(car1);
            VehicleDB.Vehicles.Add(bike1);
            VehicleDB.Vehicles.Add(vehicle1);

            foreach (var vehicle in VehicleDB.Vehicles)
            {
                if (Validator.Validate(vehicle))
                    vehicle.PrintVehicle();
                else
                    Console.WriteLine("Invalid vehicle data.");
            }
        }
    }
}