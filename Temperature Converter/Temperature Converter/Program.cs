using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace alptugg
{
    public class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            Console.WriteLine("Choose the temperature unit to convert from");
            Console.WriteLine("1.Celsius");
            Console.WriteLine("2.Fahrenheit");
            Console.WriteLine("3.Kelvin");
                
            string unittype = Console.ReadLine();
            string Celcius = "Celsius";
            string Fahrenheit = "Fahrenheit";
            string Kelvin = "Kelvin";

            if (unittype == "Celsius")
            {
                Console.WriteLine("Which do you prefer unit to convert to?");
                string unittype2 = Console.ReadLine();
                string Kelvin2 = "Kelvin";
                string Fahrenheit2 = "Fahrenheit";


                if (unittype2 == Fahrenheit2)
                {
                    Console.WriteLine("Converting celsius to fahrenheit is starting.");
                    Console.WriteLine("How much degrees celsius do you want to convert?");
                    double temp =Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine((temp *  9 / 5) + 32);

                }

                else if (unittype2 ==Kelvin2)
                {
                    Console.WriteLine("Converting celsius to Kelvin is starting.");
                    Console.WriteLine("How much degrees celsius do you want to convert?");
                    double temp = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(temp + 273);  


                }
            }

            else if (unittype ==Fahrenheit)
            {
                Console.WriteLine("Which do you prefer unit to convert to?");
                string unittype3 = Console.ReadLine();
                string Kelvin3 = "Kelvin";
                string Celsius3 = "Celsius";

                if (unittype3 == Kelvin3)
                {
                    Console.WriteLine("Converting fahrenheit to Kelvin is starting.");
                    Console.WriteLine("How much degrees fahrenheit do you want to convert?");
                    double temp = (Convert.ToDouble(Console.ReadLine()));
                    double newtemp3 = (temp - 32) * 5 / 9 + 273.15;
                    Console.WriteLine(newtemp3);



                }

                else if (unittype3 == Celsius3) 
                {
                    Console.WriteLine("Converting fahrenheit to kelvin is starting.");
                    Console.WriteLine("How much degrees fahrenheit do you want to convert?");
                    double temp = (Convert.ToDouble(Console.ReadLine()));
                    double newtemp4 = (temp - 32) * 5 / 9;
                    Console.WriteLine(newtemp4);



                }

                

            }

            else if (unittype == Kelvin)
            {
                Console.WriteLine("Which do you prefer unit to convert to?");
                string unittype4 = Console.ReadLine();
                string Fahrenheit4 = "Fahrenheit";
                string Celsius4 = "Celsius";

                if (unittype4 == Fahrenheit4)
                {
                    Console.WriteLine("Converting kelvin to fahrenheit is starting.");
                    Console.WriteLine("How much degrees kelvin do you want to convert?");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double newtemp5 = ((temp - 32) * 5 / 9) + 273 ;
                    Console.WriteLine(newtemp5);

                }

                else if (unittype4 == Celsius4)
                {
                    Console.WriteLine("Converting kelvin to celsius is starting.");
                    Console.WriteLine("How much degrees kelvin do you want to convert?");
                    double temp = Convert.ToDouble(Console.ReadLine());
                    double newtemp4 = (temp - 32) * 5 / 9;
                    Console.WriteLine(newtemp4);




                }
            }

            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            }
        }   
    }
}