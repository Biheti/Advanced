using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03Advanced.Vehicles
{
    public class Bike : Vehicle
    {
        public string Color { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Year of Production: {YearOfProduction}, Color: {Color}");
        }
    }
}
