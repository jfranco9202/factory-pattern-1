using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What type of vehicle do you want to make? Car or Motorcyle?");
            string userInput = Console.ReadLine();


            VehicleFactory factory = new VehicleFactory();
            IVehicle myVehicle = factory.CreateVehicle(userInput);

            myVehicle.Drive();

            Console.WriteLine("Lets make another vehicle?");
            userInput = Console.ReadLine();

        }
            

                 
    }
}
