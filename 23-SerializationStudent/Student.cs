using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_SerializationStudent
{
    public class Student
    {
        public Guid ID { get; set; } //global unique identifier.
        public string NameSurname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Major { get; set; }
        public double Average { get; set; }
    }
}
