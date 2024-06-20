using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PolymorphismTraitsVehicles
{
    internal class MotorVehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Motor vehicle is moving");
        }

    }
    internal class Cars : MotorVehicle
    {
        public override void Move() //overriding is polymorphism
        {
            Console.WriteLine("Car is moving");
        }
    }

    internal class Boats : MotorVehicle 
    {
        public override void Move()
        {
            Console.WriteLine("Boat is moving");
        }
    }
}


