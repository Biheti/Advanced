using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03Advanced.Vehicles
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"ID: {Id}, Type: {Type}, Year of Production: {YearOfProduction}");
        }
    }
}
