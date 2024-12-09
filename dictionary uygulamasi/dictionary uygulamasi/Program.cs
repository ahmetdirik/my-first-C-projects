using System;
using System.Collections;

namespace alptugg
{

    public class Program
    {
        static void Main(string[] args)
        {

            var PersonelListesi = new Dictionary<int, Personel>();
            PersonelListesi.Add(100,new Personel("Nehir","Iskol",80000));
            PersonelListesi.Add(101, new Personel("Emirhan", "Kalemdar",60000));
            PersonelListesi.Add(102, new Personel("Emirhan", "Abdulazizoglu",5800));
            PersonelListesi.Add(103, new Personel("Uras", "Yildirim",18000));
            PersonelListesi.Add(104, new Personel("Talha Yusfu", "Tugsal",10000));

            foreach (var Personel in PersonelListesi)
            {
                Console.WriteLine(Personel);
            }

            Console.ReadKey();
        }
    }
}