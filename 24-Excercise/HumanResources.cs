using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Excercise
{
    internal class HumanResources : Personnel
    {
        private decimal wage;

        public override decimal Wage { get => wage; 
            set 
            { 
                wage = value * 1.2m; 
            } 
        }
    }
}
