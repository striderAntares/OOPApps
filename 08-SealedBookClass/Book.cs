using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_SealedBookClass
{
    internal sealed class Book : PrintedMaterial //sealed keyword means that no one can inherit from it. a silencer. muter. sealer. the one who shall not speak to anyone ever again will be the one who were defined by it.
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public string ISBNNum { get; set; }
        public string Author { get; set; }


        //with override we can get the method from this ones inheritance, just override and hit tab.
        public sealed override void GetLog() //this just in. we can seal methods. this class is also sealed so it doesn't make sense in this context. however if it wasn't and there were another class which inherits from the book class. then we could silence this method and block the other class (hereafter NewBook class) from editing it.
        {
            //base.GetLog();
            Console.WriteLine("The logging process for the Book class has commenced.");
        }

        public sealed override void GetUser()
        {
            //base.GetUser();
            Console.WriteLine("User info is also coming here but it wouldn't came if imaginary NewBook class were to inherit from this.");
        }
    }
}
