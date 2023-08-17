using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03Advanced.Vehicles
{
    public class Car : Vehicle
    {
        public int FuelTank { get; set; }
        public List<string> CountriesProduced { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Type: {Type}, Countries Produced: {string.Join(", ", CountriesProduced)}");
        }
    }
}
