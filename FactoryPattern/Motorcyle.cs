using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Motorcyle : IVehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public bool TwoWheels { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving a mortorcyle is for crazy people.");
        }
    }
}
