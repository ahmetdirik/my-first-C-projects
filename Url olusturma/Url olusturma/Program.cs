using System;
using System.Collections;
  


namespace Kezzo
{
    public class Program
    {
        static void Main(string[] args)
        {

            //basligi okuma
            Console.WriteLine("Baslik giriniz:");
            string baslik = Console.ReadLine();
            
            //Kucultme
            baslik = baslik.ToLower();
            //Hashtable
            var karakterseti = new Hashtable()
            {
                {'ç','c' },
                {'ı','i' },
                {'ö','o' },
                {'ş','s' },
                {'ü','u' },
                {'ğ','g' },
                {':','-' },
                {',','-' },
                {'.','-' },
                {' ','-' }



            };

            foreach (DictionaryEntry key in karakterseti)
            {
                baslik = baslik.Replace((char)key.Key,(char)key.Value);
            }

            Console.WriteLine("Duzenlenmis Baslik:"+baslik);

            Console.ReadKey();
        }
    }
}