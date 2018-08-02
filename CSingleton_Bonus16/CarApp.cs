﻿using System;
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
            Car c1 = new Car("Ford", "Focus", 2005, 20000);
            Car c2 = new Car("Chevy", "Durango", 2015, 35000);
            Car c3 = new Car("Toyota", "Tacoma", 2017, 350000);
            Car c4 = new Car("Honda", "Accord", 2016, 280000);
            UsedCar uc1 = new UsedCar("Honda", "Accord", 1995, 3500, 170000);
            UsedCar uc2 = new UsedCar("Buick", "Lesabre", 2003, 1500, 180000);
            UsedCar uc3 = new UsedCar("Dodge", "Ram", 1999, 5500, 120000);
            UsedCar uc4 = new UsedCar("Chevy", "Cruze", 2005, 8000, 80000);

            List<Car> cars = new List<Car>();//new empty list
            List<Car> usedcars = new List<Car>();
            
            cars.Add(c1);
            cars.Add(c2);
            cars.Add(c3);
            cars.Add(c4);
            usedcars.Add(uc1);
            usedcars.Add(uc2);
            usedcars.Add(uc3);
            usedcars.Add(uc4);
            
            CarLot chriscars = new CarLot(cars);
            CarLot usedchriscars = new CarLot(usedcars);

            bool globalexit = true;
            while (globalexit)
            {

                bool newexit = false;
                bool usedexit = false;

                Console.WriteLine("Welcome to Chris's Cars!");
                Console.WriteLine("Would you like to look at new or used vehicles?");
                Console.WriteLine("1. Used");
                Console.WriteLine("2. New");
                string neworused = "";
                neworused = Console.ReadLine();
                if (neworused == "1")
                {
                    usedexit = true;
                }
                if (neworused == "2")
                {
                    newexit = true;
                }

                while (newexit)
                {
                    Console.WriteLine("NEW CAR DATABASE:");
                    Console.WriteLine("---------------------------------------");

                    if (chriscars.Lot.Count() == 0)
                    {
                        Console.WriteLine("Sorry, we're sold out!");
                    }
                    else
                    {
                        foreach (Car c in chriscars.Lot)
                        {
                            Console.WriteLine($"{chriscars.Lot.IndexOf(c) + 1,1}: {c.Year,-7} {c.Make,-7} {c.Model,-7}");
                        }
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Please select a number to view car info");
                    }

                    if (chriscars.Lot.Count() > 0)
                    {
                        try//using the 'remove' funciton inside an enumeration throws an exception.
                        {  //the catch of this try catch displays no message since I know that it won't cause an error for this program.
                            string input = Console.ReadLine();
                            foreach (Car c in chriscars.Lot)
                            {

                                if (chriscars.Lot.IndexOf(c) + 1 == int.Parse(input))
                                {
                                    c.PrintInfo();
                                    string yn = "";
                                    Console.WriteLine();
                                    Console.WriteLine("Would you like to buy this car? (y/n)");
                                    yn = Console.ReadLine().ToLower();

                                    if (yn == "y" || yn == "yes")
                                    {
                                        try
                                        {
                                            chriscars.RemoveCar(int.Parse(input)-1);
                                            Console.WriteLine("Enjoy your new vehicle!");
                                        }
                                        catch (Exception e)
                                        {
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (yn == "n" || yn == "no")
                                    {
                                        Console.WriteLine("OK.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yes or no!");
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to look at the inventory again? (y/n)");
                    string yn2 = Console.ReadLine().ToLower();
                    if (yn2 == "y" || yn2 == "yes")
                    {

                    }
                    else if (yn2 == "n" || yn2 == "no")
                    {
                        newexit = false;
                    }
                    else
                    {

                    }
                }

                while (usedexit)
                {
                    Console.WriteLine("USED CAR LOT:");
                    Console.WriteLine("---------------------------------------");

                    if (usedchriscars.Lot.Count() == 0)
                    {
                        Console.WriteLine("Sorry, we're sold out!");
                    }
                    else
                    {
                        foreach (Car c in usedchriscars.Lot)
                        {
                            Console.WriteLine($"{usedchriscars.Lot.IndexOf(c) + 1,1}: {c.Year,-7} {c.Make,-7} {c.Model,-7}");
                        }
                        Console.WriteLine("---------------------------------------");
                        Console.WriteLine("Please select a number to view car info");
                    }

                    if (usedchriscars.Lot.Count() > 0)
                    {
                        try//using the 'remove' funciton inside an enumeration throws an exception.
                        {  //the catch of this try catch displays no message since I know that it won't cause an error for this program.
                            string input = Console.ReadLine();
                            foreach (Car c in usedchriscars.Lot)
                            {

                                if (usedchriscars.Lot.IndexOf(c) + 1 == int.Parse(input))
                                {
                                    c.PrintInfo();
                                    string yn = "";
                                    Console.WriteLine();
                                    Console.WriteLine("Would you like to buy this car? (y/n)");
                                    yn = Console.ReadLine().ToLower();

                                    if (yn == "y" || yn == "yes")
                                    {
                                        try
                                        {
                                            usedchriscars.RemoveCar(int.Parse(input)-1);
                                            Console.WriteLine("Enjoy your new vehicle!");
                                        }
                                        catch (Exception e)
                                        {
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (yn == "n" || yn == "no")
                                    {
                                        Console.WriteLine("OK.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Yes or no!");
                                    }
                                }
                            }
                        }
                        catch (Exception e)
                        {
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to look at the inventory again? (y/n)");
                    string yn2 = Console.ReadLine().ToLower();
                    if (yn2 == "y" || yn2 == "yes")
                    {

                    }
                    else if (yn2 == "n" || yn2 == "no")
                    {
                        usedexit = false;
                    }
                    else
                    {

                    }
                }
                Console.WriteLine("Would you like to start over? (y/n)");
                string yn3 = Console.ReadLine().ToLower();
                if (yn3 == "y" || yn3 == "yes")
                {

                }
                else if (yn3 == "n" || yn3 == "no")
                {
                    globalexit = false;
                }
                else
                {

                }

            }


            //c2, c3, uc1, uc2, uc3);
            //while (true)
            //{
            //    Car temp = new Car(); //new empty car

            //    Console.WriteLine("Please provide the make of the car.");
            //    temp.Make = Console.ReadLine();

            //    Console.WriteLine("Please provide the model for the car.");
            //    temp.Model = Console.ReadLine();

            //    Console.WriteLine("Please provide the year for the car.");
            //    temp.Year = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Please provide the price of the car.");
            //    temp.Price = double.Parse(Console.ReadLine());

            //    cars.Add(temp);// add the temp object to the 'cars' list.

            //    Console.WriteLine("Do you want to add another car?");
            //    string choice = Console.ReadLine();
            //    if (choice == "n")
            //    {
            //        break;
            //    }
            //}

            //foreach (Car e in cars)
            //{
            //    Console.WriteLine($"--------------------------------------");
            //    Console.WriteLine($"Make: {e.Make}");
            //    Console.WriteLine($"Model: {e.Model}");
            //    Console.WriteLine($"Year: {e.Year}");
            //    Console.WriteLine($"Price: {e.Price}");
            //    Console.WriteLine("---------------------------------------");
            //}
        }


    }
}
