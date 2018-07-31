using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSingleton_Bonus16
{
    class CarApp
    {

        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();//new empty list

            while (true)
            {
                Car temp = new Car(); //new empty car

                Console.WriteLine("Please provide the make of the car.");
                temp.Make = Console.ReadLine();

                Console.WriteLine("Please provide the model for the car.");
                temp.Model = Console.ReadLine();

                Console.WriteLine("Please provide the year for the car.");
                temp.Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please provide the price of the car.");
                temp.Price = double.Parse(Console.ReadLine());

                cars.Add(temp);// add the temp object to the 'cars' list.

                Console.WriteLine("Do you want to add another car?");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    break;
                }
            }
            Console.WriteLine("CAR DATABASE:");
            foreach (Car e in cars)
            {
                Console.WriteLine($"--------------------------------------");
                Console.WriteLine($"Make: {e.Make}");
                Console.WriteLine($"Model: {e.Model}");
                Console.WriteLine($"Year: {e.Year}");
                Console.WriteLine($"Price: {e.Price}");
                Console.WriteLine("---------------------------------------");
            }
        }


    }
}
