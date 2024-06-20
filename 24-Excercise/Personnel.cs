using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _24_Excercise
{
    internal abstract class Personnel
    {
        public Guid PersonnelID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate 
        { get => birthdate; 
            set 
            { 
                if (DateTime.Now.Year - value.Year < 18)
                throw new Exception("Employee can't be younger than 18.");
                else 
                    birthdate = value;
            } 
        }
        public string MobileNumber { get; set; }
        public string IDNo { get; set; }
        public abstract decimal Wage { get; set; }

        private string _email;
        private DateTime birthdate;
        private DateTime startDate;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Address { get; set; }
        public DateTime StartDate 
        { get => startDate;
            set 
            {
                if (value > DateTime.Now.Date)
                    throw new Exception("Starting date can't be in the future.");
                else
                    startDate = value;
            } 
        }
        public Title Title { get; set; }
        public Sex Sex { get; set; }



    }
}
