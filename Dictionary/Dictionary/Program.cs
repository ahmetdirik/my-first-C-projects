using System;
using System.Collections.Generic;

namespace alptugg
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            var telefonKodlari = new Dictionary<int, string>()
            {
                {332,"konya" },
                {414,"bursa" },
                {466,"art" },

            };

            telefonKodlari.Add(322, "Adana");
            telefonKodlari.Add(212, "Istanbul");
            telefonKodlari.Add(216, "Istanbul");

            telefonKodlari[466] = "Artvin";

            if (!telefonKodlari.ContainsKey(312))
            {
                Console.WriteLine("\aAnkaranin kod bilgisi tanimli degil!");
                telefonKodlari.Add(312, "Ankara");
                Console.WriteLine("Yeni kod eklendi");
            }

            Console.WriteLine();

            foreach  (var s in telefonKodlari)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}