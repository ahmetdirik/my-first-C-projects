using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp9
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Array | Dizi

            int[] sayilar = new int[] {5,3,8,10,2,15,9,13,10 };
            var numbers = Array.CreateInstance(typeof(int),sayilar.Length);
            var arr = new ArrayList(sayilar); 
            
            sayilar.CopyTo(numbers,0);

            Array.Sort(sayilar);
            arr.Sort();
            Array.Sort(numbers);
            int x = Array.IndexOf(sayilar,13);
            Console.WriteLine(x);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = " +
                    $"{sayilar [i],3} - " +
                    $"numbers [{i}] = " +
                    $"{numbers.GetValue(i),3} " +
                    $"arr[{i}] = " +
                    $"{arr [i],3} ");
            }

            Console.ReadKey();
        }
    }
}
