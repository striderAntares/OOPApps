using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SealedBookClass
{
    internal abstract class PrintedMaterial //abstract because we don't want an object from it.
    {
        public int PageNumber { get; set; }
        public string PageQuality { get; set; }
        public DateTime CreationDate { get; set; }

        //virtual means we can later edit the method so it behaves in a different way in children classes.
        public virtual void GetLog()
        {
            Console.WriteLine("Log Started");
        }

        public virtual void GetUser()
        {
            Console.WriteLine("User info is coming");
        }
    }
}
