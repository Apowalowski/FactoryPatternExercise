using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Car : IVehicle
    {
        public string Color { get; set; }
        public string IsDrivable { get; set; }
        public void Drive()
        {
            Console.WriteLine($"Can't text I'm driving in my {Color} Car. ");
        }
    }
}
