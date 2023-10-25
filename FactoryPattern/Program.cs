﻿namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            int wheelCount;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of tires for the vehicle you want to create");


                input = int.TryParse(Console.ReadLine(), out wheelCount);
            } while (!input);

            IVehicle vehicle = VehicleFactory.GetVehicle(wheelCount);

            vehicle.Drive();
            
        }
    }
}
