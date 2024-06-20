using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOPGenericConcept
{
    internal class GenericClass<T> /*where T : struct, Enum */ //this T is a placeholder, you can define it on taking instance. where keyword is usable if its an interface. ie enum structs. we need it if the same property requires different types. an id can be guid it can be int it can be string. instead of populating the class with each type we put a placeholder and replace it while taking instance. it is a convenience.
    {
        public T ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
