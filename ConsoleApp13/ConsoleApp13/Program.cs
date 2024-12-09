using System;
using System.Collections;
using System.ComponentModel;

namespace Projemm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayi giriniz:");
            string sayi = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            foreach (char rakam in sayi)
            {
                stack.Push(int.Parse(rakam.ToString()));
            }

            Console.WriteLine("Sayinin elemanlari birler basamagindan itibaren:");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadKey();

            Console.WriteLine("Sayilarin ondalik degerleri:");

            foreach (char rakam in sayi)
            {
                stack.Push(int.Parse(rakam.ToString()));
            }

            int basamakdegeri = 1;

            while (stack.Count > 0)
            { 
               
                int basamak = stack.Pop();
                int ondalikgosterim = basamak * basamakdegeri;
                Console.WriteLine(ondalikgosterim);
                basamakdegeri *=10;
            }


            Console.ReadKey();
        }
    }
}