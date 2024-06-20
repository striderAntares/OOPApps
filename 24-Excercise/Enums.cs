using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Excercise
{

    public enum Title
    {
        [Display(Name = "Software Developer")]
        SoftwareDeveloper = 0,
        [Display(Name = "Human Resources")]
        HumanResources,
        [Display(Name = "Accountant")]
        Accountant,
        [Display(Name = "Turbine Engineer")]
        TurbineEngineer,
        [Display(Name = "Reactor Engineer")]
        ReactorEngineer
    }
    public enum Sex
    {
        [Display(Name = "Male")]
        Male = 0,
        [Display(Name = "Female")]
        Female
    }

}
