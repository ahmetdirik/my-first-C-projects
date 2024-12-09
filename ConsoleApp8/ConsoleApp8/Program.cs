using ConsoleApp8;
using System;
using System.Collections.Generic;

namespace BTKAkademi.ProgramlamaTemelleri
{
    // Tanımlama
 
    public struct Ogrenci
    {
        // Yapılandırıcı metot - Constructor
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet = true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; } // Property - Özellik
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        // Geçersiz kılmak / Ezmek / Override
        public override string ToString()
        {
            return $"{Numara}, {Adi}, {Soyadi}, {(Cinsiyet ? "Erkek" : "Kadın")}";
        }

        public static void Calistir()
        {
            // Method content
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var Liste1 = 
                new List<OgretimElemani>() 
                {
                    new OgretimElemani(120,"Ahmet","Dirik",true),
                    new OgretimElemani(121,"Alptug","Dirik",true),
                    new OgretimElemani(122,"Metehan","Dirik",true),
                    new OgretimElemani(123,"Kut","Dirik",true),
                    new OgretimElemani(124,"Tomris","Dirik",false),
                    new OgretimElemani(5,"Nehir","Dirik",false),

                };
            Console.WriteLine("Liste1");
            Liste1.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine("Liste2");

            var Liste2 = Liste1;
            Liste2.ForEach(ogr => Console.WriteLine(ogr));
            Liste2.Add(new OgretimElemani(290,"Hosnaze","Dirik",false));
            Console.WriteLine();
            Liste2.ForEach(ogr => Console.WriteLine(ogr));
            Console.WriteLine();
            Liste1.ForEach(ogr => Console.WriteLine(ogr));

            Console.ReadKey();

        }
    }
}