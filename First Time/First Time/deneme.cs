using System;
using System.Collections.Generic;

namespace denemeiki
{
    public class Program
    {
        static void Main(string[] args)
        {
            var k = Convert.ToInt32(Console.ReadLine());
            if k%k
            {
                Console.WriteLine("Girilen ifade bir sayidir.");
            }
            else if (char.IsLower(k))
            {
                Console.WriteLine("kucuk karakter.");

            }
            else if (char.IsUpper(k))
                Console.WriteLine("buyuk karakter.");
            Console.WriteLine(k);   




            Console.ReadKey();

        }
    }
   
}
