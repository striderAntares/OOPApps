using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOPStaticPhysicsLibrary
{
    internal static class ExtensionMethods
    {
        public static bool IDNoControl(long idNo)
        { 
            return true; 
        }//we need static methods so we would not have to take an instance of a class every time we want to use the method. 
        public static string ClearString(this string param) //by adding this keyword to parameter we created an actual extension method. extension method requires his class to be static as well. you remember them as purple cubes with an arrow pointing down near them. 
        {
            param = param.ToLower().Replace("ş","s").Replace("ğ","g").Replace("ç","c").Replace("ü","u").Replace("ı","i").Replace("ö","o").Replace("â","a");

            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(param); //pascal case, first letter big
        }
    }
}
