using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOPClass
{
    internal class Personnel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Kids { get; set; }
        public string Title { get; set; }
        //public decimal Wage { get; }
        public int IDNo { get; set; }
        //Wage of the Personnel shouldn't be able to be setted by everyone. so we deleted the set keyword from the property. it is now a ReadOnly.
        //Encapsulation - seek fulfillment of certain conditions before a property gets setted. 
        // For Encapsulation we need a field property.
        private decimal _wage; //this field means when a value is added to the property its value is added to the field. and when you get a value from a property it comes from the field.
        public decimal Wage
        {
            //get method gets the data from the prop. you can modify it while getting. this doesn't change the source for obvious reasons.
            get
            {
                if (_wage > 0)
                    return _wage;
                else
                    return 0;
            }
            //sets sets the prop to desired value. you can add your conditions here.
            set
            {
                if (Title != "Specialist" || value < 59000)
                    Console.WriteLine("You either need clearance or your wage is lower than first class engineer");
                else
                    _wage = value;
            }


        }

        public void GetSome(decimal Percentage)
        {
            Wage = Wage * (1 + Percentage);
        }
        private decimal _socialHelpWage;

        public decimal WagewSocialHelp
        {
            get
            {
                if (Kids == 0)
                    return _socialHelpWage;
                else
                {
                    return _socialHelpWage = Wage * (1 + 0.3m);
                }
            }

        }

    }


}
