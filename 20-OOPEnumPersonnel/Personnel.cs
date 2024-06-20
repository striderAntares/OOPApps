using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_OOPEnumPersonnel
{
    internal class Personnel
    {
        public string NameSurname { get; set; }
        public string PersonnelUnits { get; set; }
        public enum Units
        {
            SoftwareDevelopment = 0,
            CyberSecurity,
            Accounting,
            English,
            Management,
            InformationTechnologies
        }
    }
}
