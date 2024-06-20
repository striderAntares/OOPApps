using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InterfaceVehicle
{
    internal class Cars
    {
    }
    internal class Mercedes : ICommonFeaturesofCars, IMerco
    {
        private string _marka = "Mercedes";
        public string Brand
        {
            get
            {
                return _marka;
            }
        }
        public int Speed { get; set; }
        public int Model { get; set; }
        public decimal Cost { get; set; }
        public bool CanRated { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Indicator()
        {
            throw new NotImplementedException();
        }

        public void Information()
        {
            Console.WriteLine($"Cost: {Cost}\n Brand: {Brand}\n Model: {Model}\n Speed: {Speed}" );
        }

        public double RateIt(double rating)
        {
            return rating * 2.5;
        }
    }
    internal class BMW : ICommonFeaturesofCars
    {
        private string _marka = "BMW";
        public string Brand => _marka;
        public int Speed { get; set; }
        public int Model { get; set/* => throw new NotImplementedException()*/; } // this throw bullshit is just a placeholder for actual implementing.
        public decimal Cost { get; set; }

        public void Indicator()
        {
            throw new NotImplementedException();
        }

        public void Information()
        {
            Console.WriteLine($"Cost: {Cost}\n Brand: {Brand}\n Model: {Model}\n Speed: {Speed}");
        }
    }
    internal interface ICommonFeaturesofCars
    {
        public string Brand { get; }
        public int Speed { get; set; }
        public int Model { get; set; }
        public decimal Cost { get; set; }
        public void Information();
        public void Indicator();
    }

    internal interface IMerco
    {
        public bool CanRated { get; set; }
        public double RateIt(double rating);
    }
}
