using _01_OOPCounterStrikeClassLibrary.Concrete;
using _01_OOPCounterStrikeClassLibrary.Enum;
namespace _26_TryingToAddReference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Weapon wpn = new Weapon("Colt", "1887", 750, true, Ranged.MidRange);
            Console.WriteLine(wpn.Kill());
            Console.WriteLine(wpn.Hurt());
        }
    }
}