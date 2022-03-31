using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "Car":
                    return new Car() { Make = "Honda", Model = "Civic", Year = 2015, SmallTrunk = true };
                case "Motorcyle":
                    return new Motorcyle() { Make = "Harley", Model = "Chopper", Year = 2017, TwoWheels = true };
                default:
                    return new Car();
                    
            }

        }
        
    }
    
            
                
           
            
    
}
