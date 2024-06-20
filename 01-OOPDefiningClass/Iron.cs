using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OOPDefiningClass
{
    internal class Iron
    {
        //public private internal access modifiers. 
        //public: Code in any assembly can access this type or member. The accessibility level of the containing type controls the accessibility level of public members of the type.
        //private: Only code declared in the same class or struct can access this member.
        //protected: Only code in the same class or in a derived class can access this type or member.
        //internal: Only code in the same assembly can access this type or member.
        //protected internal: Only code in the same assembly or in a derived class in another assembly can access this type or member.
        //private protected: Only code in the same assembly and in the same class or a derived class can access the type or member.
        // syntax of properties:
        // AccessModifier DataType PropertyName {get; set;}
        public string Brand { get; set; } //in order to create a property you can type prop and press tab.
        public string Colour { get; set; }
        public int Temperature { get; set; }
        public bool HasBoiler { get; set; }

        //Constructor Method
        //ctor + Tab + Tab
        //There is a default constructor. We don't need to create one.

        //this is an empty constructor
        public Iron()
        {
            Console.WriteLine("Iron Class has been created");
        }

        //what if i want to create one with a parameter?

        public Iron(string brand, string colour, bool hasBoiler, int temperature)
        {
            this.Brand = brand;
            this.Colour = colour;
            this.Temperature = temperature;
            this.HasBoiler = hasBoiler;
            Console.WriteLine($"Iron object has been created with following information:\n Brand: {Brand}\n Colour: {Colour}\n Temperature: {Temperature}\n Has Boiler: {(HasBoiler ? "Yes" : "No")}");

        }

    }
}
