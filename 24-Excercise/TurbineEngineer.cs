using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Excercise
{
    internal class TurbineEngineer : Personnel
    {
        private decimal wage;

        public override decimal Wage
        {
            get => wage;
            set
            {
                wage = value * 0.9m;
            }
        }
    }
}
