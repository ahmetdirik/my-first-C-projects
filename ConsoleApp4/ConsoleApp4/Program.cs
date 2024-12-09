using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.Serialization;


namespace MyNamespace
{
    public class Program
    {
        static void Main(string[] args)
        {

            var odenecekmiktar = Satisyap(100,0.2);
            Console.WriteLine("{0,5:##}",odenecekmiktar);
            Console.ReadKey();
        }

        private static double Satisyap(double miktar)
        {
            return miktar * 1.18;
        }

        private static double Satisyap(double miktar,double indirim)
        {
            return miktar * (1.0-indirim) * 1.18;
        }

        private static double GetToplam(params double[] seri)
        {
            double toplam =0;   
            foreach (double s in seri) 
                    toplam += s;
            return toplam;
        }

        //public static int Karsilastir(int A, int B)
        //{
        //    return A>B ? A: B; 

        //    Console.WriteLine();

            
                   

            
                
        //}

        //static double KareAl(double sayi) 
        //    {
        //        double kare = sayi * sayi;
        //    return kare;
        //    }

            
    }
}



//var sayilar = new List<int>() { 30, 40, 50 };

//int x = 55;




//sayilar.Add(x);
//sayilar.AddRange(new int[] { 70, 80, 90 });

//sayilar.Insert(3, 0);

//sayilar.RemoveAt(3);
//sayilar.RemoveAt(sayilar.IndexOf(50));


////foreach (var item in seri) 
////{
////    sayilar.Add(item);
////}


//foreach (var s in sayilar)
//{
//    Console.Write($"{s,-5}");
//}