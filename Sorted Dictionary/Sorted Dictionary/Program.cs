using System;
using System.Collections.Generic;


namespace alptugg
{
    public class program
    {
        static void Main(string[] args)
        {
            var KitapIndex = new SortedDictionary<string, List<int>>()
            {
                {"HTML", new List<int>() { 8, 10, 12}},
                {"CSS", new List<int> { 70, 80, 90}},
                {"JQERY", new List<int> { 3,5,15}},
                {"SQL", new List<int>{70, 80} }

            };

            KitapIndex.Add("FTP",new List<int>() { 3, 5, 7 } );
            KitapIndex.Add("ASP.NET", new List<int>() { 50, 60 });


            foreach (var KAVARM  in KitapIndex ) 
            {
            
                Console.WriteLine( KAVARM.Key );

                foreach  (int value in KAVARM.Value)
                {
                    Console.WriteLine($"\t > {value}");
                }
            }



            Console.ReadKey();
        }
    }
}