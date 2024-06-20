using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOPGenericConcept
{
    internal class NonGenericClass
    {
        public void PrintToScreen<T>(T data) //a generic method
        {
            Console.WriteLine("Type T data: " + data);

        }
    }
}
