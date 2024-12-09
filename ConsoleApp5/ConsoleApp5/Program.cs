using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Serialization;



namespace sagopakajmer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sehirler = new List<String>()
            {
                "Ankara",
                "Istanbul",
                "Van",
                "Sivas",
                "Ordu"
            };

            sehirler.ForEach(s => Console.WriteLine(s));


            Console.WriteLine(new string('-', 50));

            var iller = sehirler;
            iller.ForEach(i => Console.WriteLine(i));

            Console.WriteLine(new string('-', 50));

            sehirler.Add("Sinop");
            sehirler.ForEach(s => Console.WriteLine(s));
            Console.WriteLine();
            iller.ForEach(i => Console.WriteLine(i));
           

            iller.Remove("Ankara");
            iller.ForEach(i => Console.WriteLine(i));
            Console.ReadKey();
        }
 
    }
}

//{
//    int x = 10;
//    int y = 20;
//    Console.WriteLine("{0},{1}", x, y);
//    Degistir(ref x,ref y);
//    Console.WriteLine("{0},{1}", x, y);
//    Console.ReadKey();
//}
//private static void Degistir(ref int a, ref int b)
//{
//    int gecici = a;
//    a= b;
//    b = gecici;
//    Console.WriteLine("{0},{1}", a, b);
//}
