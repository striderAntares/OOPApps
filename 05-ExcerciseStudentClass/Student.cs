using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ExcerciseStudentClass
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }

        private int _age;

        public int Age
        {
            get 
            {
                _age = DateTime.Now.Year - Birthdate.Year; 
                return _age; 
            }
            
        }

        public void PrintInfoStudent()
        {
            Console.WriteLine("Name: " + Name + " Student: " + Surname + " Age: " + Age);
        }
       

    }
}
