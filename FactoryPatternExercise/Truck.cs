using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Truck : IVehicle
    {
        public string Colors { get; set; }
        public bool HasBed { get; set; } = true;
        
        public void Drive()
        {
            Console.WriteLine("Sorry I can't text I'm driving");
        }
    }
}
