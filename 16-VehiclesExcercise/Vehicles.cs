using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_VehiclesExcercise
{
    internal class Vehicles
    {
        public int Speed { get; set; }
        public string Colour { get; set; }
        public virtual void ShowVehicleInfo()
        {
            Console.WriteLine("Speed: " + Speed + " " + "Colour: " + Colour);
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle stopped");
        }
    }
    internal class Cars : Vehicles, IFuel, IActions
    {
        public string FuelType { get; set; }
        public void DecreaseShift(int shift)
        {
            shift--;
            Console.WriteLine("Shift decreased: " + shift);
        }

        public void Drive()
        {
            {
                Console.WriteLine("Driving..");
            }
        }

        public void IncreaseShift(int shift)
        {
            shift++;
            Console.WriteLine("Shift increased: " + shift);
        }

        public void Park()
        {
            {
                Console.WriteLine("Parked..");
            }
        }
        public override void ShowVehicleInfo()
        {
            Console.WriteLine("Car\n" + "Fuel type: " + FuelType);
            base.ShowVehicleInfo();
        }
    }
    internal interface IFuel
    {
        public string FuelType { get; set; }
    }
    internal interface IActions
    {

        public void Drive();

        public void Park();

        public void IncreaseShift(int shift);
        public void DecreaseShift(int shift);

    }
    internal class Ship : Vehicles
    {
        public void GetMaintenance()
        {
            Console.WriteLine("Maintenance begun..");
        }
        public void GetToHelm()
        {
            Console.WriteLine("Ahoy, Captain on the bridge!");
        }
        public void AnchorToPort()
        {
            Console.WriteLine("Time for rum!");
        }
        public override void ShowVehicleInfo()
        {
            Console.WriteLine("Ship");
            base.ShowVehicleInfo();

        }
    }
    internal class MotorBike : Vehicles, IActions 
    {
        public string MotorType { get; set; }

        public void DecreaseShift(int shift)
        {
            shift--;
            Console.WriteLine("Shift decreased: " + shift);
        }

        public void Drive()
        {
            {
                Console.WriteLine("Driving..");
            }
        }

        public void IncreaseShift(int shift)
        {
            shift++;
            Console.WriteLine("Shift increased: " + shift);
        }

        public void Park()
        {
            {
                Console.WriteLine("Parked..");
            }
        }
        public override void ShowVehicleInfo()
        {
            Console.WriteLine("Motorbike\n" + "Motor type: " + MotorType);
            base.ShowVehicleInfo();
        }
    }
}
