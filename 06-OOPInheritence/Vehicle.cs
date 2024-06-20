using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOPInheritence
{
    internal class Vehicle
    {
        public int ID { get; set; }
        public int NumberOfTires { get; set; }
        private int MaximumVelocity { get; /*private*/ set; } //here we can change access level to private so others can't change or view it. but we can write a method here which can change and write it and call it on other projects.
        public int PassengerCapacity { get; set; }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public DateTime ModelYear { get; set; }


        public Vehicle() //this will apply to all the inherited classes. when cars inherit from this their maximum velocity will be set as well. it is possible to create the object with constructors. just add parameters and define one of them as default(define with a value). and send it with other.
        {
            MaximumVelocity = 200;
        }
        public void PrintMaxVelocity()
        {
            Console.WriteLine("Max velocity: " + MaximumVelocity); //earlier we set the access level of this method to private this meant in other project developer can't access it. but if he can't access it how can he print it? this is the way.
        }

    }
}
