using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args) 
        {

            var arraylist = new ArrayList() { 10 , "Sagopa Kajmer" , true , 'e' };
            foreach (var e in arraylist) 
            {
                Console.Write($" {e} ");
            }

            int[] sayilar = new int[] {23,44,55 };
            arraylist.AddRange(sayilar);
            Console.WriteLine();
            foreach (var e in arraylist)
            {
                Console.Write($" {e} ");
            }
            Console.ReadKey();
        }

       
       
    }
}

//static void Main(string[] args)
//{
//    double[,] matris = new double[,]
//    {
//                { 1, 2, 3 },
//                { 2, 3, 4 },
//                { 3, 4, 5 }
//    };

//    for (int i = 0; i < matris.GetLength(0); i++)
//    {
//        for (int j = 0; j < matris.GetLength(1); j++)
//        {
//            if (matris[i, j] % 2 == 0)
//            {
//                matris[i, j] = 0;
//            }
//            Console.Write($"{matris[i, j],5}");
//        }
//        Console.WriteLine();
//    }

//    Console.ReadKey();




//}