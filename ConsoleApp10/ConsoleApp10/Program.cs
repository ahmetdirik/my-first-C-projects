using System;
using System.Collections;

namespace BTKAkademi.ProgramlamaTemelleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            // HASHTABLE
            var sehirler = new Hashtable();

            // Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "Istanbul");
            sehirler.Add(58, "Sivas");
            sehirler.Add(23, "Elazig");

            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5} " +
                    $"{item.Value,-5}");

            }
            //anahtarlari alma

            var anahtarlar = sehirler.Keys;

            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}