using System;
using System.Collections.Generic;
namespace alptugg
{
    public struct Nokta
    {
        public int X { get; set; }
        public int Y { get; set; }
        



        public override string ToString()
        {
            return $"{X},{Y}";
        }

        //default constructer
        public Nokta(int x, int y)
        {
            X = x;
            Y = y;
        }


        public void SetOrigin()
        {
            this.X = 0;
            this.Y = 0;
        }


        public void Degistir()
        {
            var gecici = X;
            X = Y;
            Y = gecici;

        }


        public void RevertToOriginal(int originalX, int originalY)
        {
            X = originalX;
            Y = originalY;
        }

    }





    //public struct Cumle
    //{
    //    public string Word1 { get; set; }

    //    public string Word2 { get; set; }

    //    public string Word3 { get; set; }




    //    public Cumle(string word1, string word2, string word3)
    //    {
    //        Word1 = word1;
    //        Word2 = word2;
    //        Word3 = word3;
    //    }

    //    public void PrintWords()
    //    {
    //        Console.WriteLine($"{Word1} {Word2} {Word3}");
    //    }
    //}




    //    public class Program
    //    {

    //        static void Main(string[] args)
    //    {
    //        Cumle cumle = new Cumle("Seni","Cok", "Seviyorum");

    //        // Verilen değerleri ekrana yazdırıyoruz.
    //        cumle.PrintWords();

    //        Console.ReadKey();

    //    }




    //}
    static class Program
    {
        static void Main(string[] args)
        {
            var n1 = new Nokta(4,1); 
            Console.WriteLine(n1);
            n1.Degistir();
            Console.WriteLine(n1);
            n1.SetOrigin();
            Console.WriteLine(n1);
            n1.RevertToOriginal(4,1);
            Console.WriteLine(n1);
            var n2 = n1;
            Console.WriteLine(n2);
            n2.X = -1 * n2.X;
            n2.Y = -1 * n2.Y;
            Console.WriteLine(n2);
            Console.ReadKey();


        }
    }


}
