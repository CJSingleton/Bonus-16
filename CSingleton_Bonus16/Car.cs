using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSingleton_Bonus16
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make
        {

            set
            {
                //if (!Regex.IsMatch(value.ToString(), @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"))
                //{
                //    throw new Exception("That is not valid input.");
                //}
                //else
                //{
                    make = value;
                //}
            }
            get { return make; }
        }
        public string Model
        {
            set
            {
                //if (!Regex.IsMatch(value.ToString(), @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"))
                //{
                //    throw new Exception("That is not valid input.");
                //}
                //else
                //{
                    model = value;
                //}
            }
            get { return model; }
        }
        public int Year
        {
            set
            {
                //if (!Regex.IsMatch(value.ToString(), @"^[\d]{4}$"))
                //{
                //    throw new Exception("That is not valid input.");
                //}
                //else
                //{
                    year = value;
                //}
            }
            get { return year; }
        }
        public double Price
        {
            set
            {
                //if (!Regex.IsMatch(value.ToString(), @"^[\d]{1, }.[\d]{1,2}$"))
                //{
                //    throw new Exception("That is not valid input.");
                //}
                //else
                //{
                    price = value;
                //}
            }
            get { return price; }
        }

        public Car()// default constructor (no argument constructor)
        {
            Make = "not assigned";
            Model = "not assigned";
            Year = 0000;
            Price = 0;
        }

        public Car(string mk, string md, int y, double p) //Overloaded constructor
        {
            Make = mk;
            Model = md;
            Year = y;
            Price = p;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{"Make", -5}: {Make}");
            Console.WriteLine($"{"Model", -5}: {Model}");
            Console.WriteLine($"{"Year", -5}: {Year}");
            Console.WriteLine($"{"Price", -5}: {Price:C}");
        }
    }
}
