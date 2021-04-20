using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    class Motorcycle : IVehicle
    {
        public bool HasTwoWheels { get; set; } = true;
        public string NotSafe { get; set; }
        public void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
