using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OOPInterfacePersonnel
{
    internal class Personnel//We use classes for declaring common properties of different classes. We use interfaces for declaring different properties of different classes.
    {
        public string NameSurname { get; set; }
        public DateTime Birthdate { get; set; }
        public decimal Wage { get; set; }
        public DateTime StartDate { get; set; }
        public string Task { get; set; }

        
    }

    internal class HumanResources : Personnel , ICanUsePrinter , ICanOrderFood
    {
        public bool CanHire { get; set; }
        public bool CanGetWage { get; set; }
        public bool CanUsePrinter { get; set; }
        public bool CanOrderFood { get; set; }
    }

    internal class Accounting : Personnel , ICanUsePrinter
    {
        public bool CanPayWage { get; set; }
        public bool CanGetPayments { get; set; }
        public bool CanUsePrinter { get; set; }
    }
    internal class InformationTechnologies : Personnel , ICanUsePrinter
    {
        public bool CanPurchaseComp { get; set; }
        public bool CanSetNetwork { get; set; }
        public bool CanUsePrinter { get; set; } //interfaces are just that interfaces. you can write them here individually nothing would really change. you just have to edit them individually also when you need to edit. so for convenience use interfaces. perchance
    }
}
