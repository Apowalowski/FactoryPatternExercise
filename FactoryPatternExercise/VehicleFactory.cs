using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch(userInput.ToLower())
            {
                case "car":
                    return new Car();
                   
                case "truck":
                    return new Truck();
                case "motorcycle":
                    return new Motorcycle();

                default:
                    return new Car();
                    
            }
        }
    }
}
