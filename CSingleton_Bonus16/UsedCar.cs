using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Bonus16
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }

        public UsedCar()
        {
            Mileage = 50000;
        }

        public UsedCar(string mk, string md, int y, double p, int ml) : base(mk,md,y,p)
        {
            Mileage = ml;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Mileage: {Mileage -5}");
        }
    }
}
