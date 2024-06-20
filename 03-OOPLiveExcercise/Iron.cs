using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOPLiveExcercise
{
    internal class Iron
    {
        public string Brand { get; set; }
        public string Colour { get; set; }

        private int _temperature;

        public int Temperature
        {
            get
            {
                return _temperature;
            }
            set
            {
                if (value > 100)
                {
                    Console.WriteLine("Temperature can't be higher than 100");
                    _temperature = 100;
                }
                else
                    _temperature = value;
            }
        }

        public void IncreaseTemperature(int degree)
        {
            Temperature += degree;
        }

    }
}
