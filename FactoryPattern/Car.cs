﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {

        }
        public void Drive()
        {
            Console.WriteLine($"The car is driving! Wooo!");
        }
    }
}
