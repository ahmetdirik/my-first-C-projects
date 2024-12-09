using System;
using System.Collections;


namespace stackyapisi
{
    public class Program
    {

        static void Main(string[] args)
        {
            var karakteryigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakteryigini.Push((char)i);
                Console.WriteLine($"{karakteryigini.Peek()}");
                            Console.WriteLine($"yigindaki eleman sayisi: {karakteryigini.Count}");
            }

            var dizi =
            Console.WriteLine("Yığından çıkartma işlemi için bir tuşa basınız.");


            Console.ReadKey();

            while (karakteryigini.Count > 0)
            {
                Console.WriteLine(karakteryigini.Pop());
                Console.WriteLine($"yigindaki eleman sayisi: {karakteryigini.Count}");
            }

            Console.ReadKey();

        }
        //static void Main(string[] args)
        //{
        //    //stack tanimlama 
        //    var karakteryigini = new Stack<char>();
        //    //karakter ekleme
        //    karakteryigini.Push('A');
        //    Console.WriteLine(karakteryigini.Peek());
        //    karakteryigini.Push('B');
        //    Console.WriteLine(karakteryigini.Peek());

        //    karakteryigini.Push('C');
        //    Console.WriteLine(karakteryigini.Peek());





        //    Console.ReadKey();
        //}
    }
}