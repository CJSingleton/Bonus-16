using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Bonus16
{
    public class CarLot 
    {
        private List<Car> lot;// CarLot is a class for lists
        

        public List<Car> Lot
        {
            get { return lot; }
            set { lot = value; }
        }

        public CarLot()
        {
            Lot = new List<Car>();
        }

        public CarLot(List<Car> input)
        {
            Lot = input;
        }

        public void RemoveCar(int input)
        {
            Lot.RemoveAt(input);//removes the car at the specified index number.
        }

        public void AddCar()
        {

        }

        

        

        //public AddCar()

        //public RemoveCar()

        //public Lookup()

        //public Replace()


    }
}
