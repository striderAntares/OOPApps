using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_OOPGenericConcept
{
    internal class KeyValueDuo<TKey,TValue>
    {
        public TKey ID { get; set; }
        public TValue Name { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
