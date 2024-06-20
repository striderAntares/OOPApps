using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_AbstractionVehicles
{
    internal abstract class MotorVehicle
    {
        public abstract void Move(); //abstract methods can't have bodies. an abstract method can't exist in a non abstract class. however a non abstract method can exist in an abstract class. you can even declare the non abstract method as virtual so you can later override it when you give the class for inheritance.
        
    }
    internal class Car : MotorVehicle
    {
        public override void Move() //virtual abstract or override is needed at the target in order to override the target. abstract : no instance but can inherit to others. virtual: makes it overrideable and instancable.
        {
            //base.Move();
        }
    }
}
