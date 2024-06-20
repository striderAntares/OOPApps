using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOPStaticPhysicsLibrary
{
    internal class Physics
    {
        public static decimal Gravity { get; set; } //property
        public const int buoyancy = 5; //constant members require assigning.
        int x; //fields
        public static readonly int force; //this is a readonly. it means it can't have a value change unless you use static constructors.
        //static constructors can't have parameters or access modifiers.
        static Physics()
        {
            force = 0 + buoyancy;
        }
    }
}
