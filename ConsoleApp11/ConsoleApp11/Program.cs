using System;
using System.Collections;

namespace sagokafkef
{
    public class Program
    {
        static void Main(string[] args)
        {
            var kitapicerigi = new SortedList();
            kitapicerigi.Add(1, "Onsoz");
            kitapicerigi.Add(50, "Degiskenler");
            kitapicerigi.Add(40, "Operatorler");
            kitapicerigi.Add(25,"Fonksiyonlar");
            kitapicerigi.Add(60,"Donguler");
            kitapicerigi.Add(30,"Iliskisek Operatorler");

            Console.WriteLine("Icindekiler:");
            Console.WriteLine(new string('-',25 ));

            foreach(DictionaryEntry i in kitapicerigi)
            {
                Console.WriteLine($"{ i.Key,-5} {i.Value,-20}");
            }

            Console.ReadKey();
        }
    }
}