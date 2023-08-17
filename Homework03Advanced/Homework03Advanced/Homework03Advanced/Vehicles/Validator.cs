using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework03Advanced.Vehicles
{
    static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            return vehicle.Id != 0 && vehicle.Type != string.Empty && vehicle.YearOfProduction != 0;
        }
    }
}
