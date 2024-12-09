using System;
using System.Collections;

namespace SebnemFerah
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sesliharfler = new List<char>()
            {
                'a','e','i','o','u'
            };

            var harflistesi = new Queue<char>();
            Console.WriteLine("Yeni sira olusturuldu");


            ConsoleKeyInfo secim;
            foreach (char harf in sesliharfler)
            {
                Console.WriteLine();
                Console.WriteLine($"{harf,-5} listeye eklensin mi? [e/h] ");
                secim = Console.ReadKey();
                Console.ReadKey();
                if (secim.Key == ConsoleKey.E)
                {
                    harflistesi.Enqueue(harf);
                    Console.WriteLine($"{harf} listeye eklendi");
                }

                Console.WriteLine($"Kuyruktaki eleman sayisi:{harflistesi.Count}");
            }
            Console.WriteLine();
            Console.WriteLine("Kuyruktaki elemanlari cikarmak istiyorsaniz esc tusuna basiniz");
            Console.WriteLine();

            secim = Console.ReadKey();
            if ( secim.Key == ConsoleKey.Escape)
            {
                while (harflistesi.Count > 0)
                {
                    Console.WriteLine($"{harflistesi.Peek(),-5} listeden cikariliyor");
                    Console.WriteLine($"{harflistesi.Dequeue(),-5} listeden cikarildi");
                    Console.WriteLine($"Kuyruktaki eleman sayisi: {harflistesi.Count}");

                    sesliharfler.Clear();
                }
            }

            Console.ReadKey();
        }

        private static void kuyruktemelleri()
        {
            // Tanımlama
            var karakterKuyrugu = new Queue<char>();


            // Ekleme
            karakterKuyrugu.Enqueue('a');
            karakterKuyrugu.Enqueue('e');
            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count}");

            // Diziye atama
            var dizi = karakterKuyrugu.ToArray();

            // Çıkarma
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
            Console.WriteLine($"{karakterKuyrugu.Dequeue()} kuyruktan çıkartıldı.");
            Console.WriteLine($"Eleman sayısı: {karakterKuyrugu.Count}");
            Console.WriteLine($"Kuyruğun başındaki eleman: {karakterKuyrugu.Peek()}");
        }
    }
}