using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Excercise
{
    internal class Iron
    {
        public string Brand { get; set; }

        private string _colour;

        public string Colour
        {
            get { return _colour; }
            set 
            {
                if(value == "Blue")
                _colour = value;
                else
                    _colour = "Not clarified";
            }
        }

        public int Temperature { get; set; }
    }
}
