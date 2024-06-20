using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPInterfaceBallers
{
    internal interface IGoaliee : IBallers
    {
        public bool CanUseHands { get; set; }
    }
}
