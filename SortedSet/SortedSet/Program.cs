using System;
using System.Collections;
    
namespace alptugg
{
    public class program
    {
        static void Main(string[] args) 
        { 
            var sayilar =new List<int>();

            var r = new Random ();

            for (int i = 0; i < 100; i++) 
            {
                sayilar.Add(r.Next(0, 25));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            //listedeki benzersiz elamanlari bulmak

            var benzersizsayilistesi = new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin listesi:\n");
            foreach (int sayi in benzersizsayilistesi)
            {
                Console.Write($"{sayi,-3}");
            }

            Console.WriteLine("Benzersiz su kadar sayi var {0}",benzersizsayilistesi.Count);

            Console.ReadKey();
        }
    }
}