using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            // List
            var sayilar = new List<int>() { 53, 40, 14, 2, 3, 12, 15 };
            sayilar.Sort();
            sayilar.ForEach(s => Console.WriteLine(s));

            //Sehir listesi
            var sehirler = new List<Sehir>()
            {
               new Sehir(06, "Ankara"),
               new Sehir (34, "Istanbul"),
               new Sehir (55, "Samsun"),
               new Sehir(58, "Sivas"),
               new Sehir (23, "Elazig"),
               new Sehir (44, "Malatya"),
            };

            sehirler.Add(new Sehir(1, "Adana"));
            sehirler.Sort();
            sehirler.ForEach(se => Console.WriteLine(se));

            Console.ReadKey();
        }
    }
}