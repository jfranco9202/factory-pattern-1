using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Car : IVehicle
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public bool SmallTrunk { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Remember don't text and drive in my {Make} car");
        }
    }
}
