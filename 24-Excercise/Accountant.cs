using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Excercise
{
    internal class Accountant:Personnel
    {
        public Accountant(string name, string surname, DateTime dt)
        {
            Name = name;
            Surname = surname;
            Birthdate = dt;
        }

        private decimal wage;

        public override decimal Wage
        {
            get => wage;
            set
            {
                wage = value * 1.1m;
            }
        }
    }
}
