using System;
using System.Collections.Generic;

namespace alptugg
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SortedSet Küme işlemleri
            var A = new SortedSet<int>(RastgeleSayiUret(100));
            //var B = new SortedSet<int>() { 1, 2, 5, 6};
            var B = new SortedSet<int>(RastgeleSayiUret(100));


            #region
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            #endregion

            //Union 
            //A.UnionWith( B );
            A.IntersectWith( B );
            Console.WriteLine("A ve B kumesinin kesisimi");
            foreach(int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("{0} a ve b kumelerinin kesimideki eleman sayisi", A.Count);
            static List<int> RastgeleSayiUret(int n)
            {
                var list = new List<int>();
                var r = new Random();
                for (int i = 0; i < n; i++)
                    list.Add(r.Next(0, 1000));
                return list;
            }





            Console.ReadKey();


        }
    }
}