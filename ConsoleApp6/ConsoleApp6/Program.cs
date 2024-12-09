using System;
using System.Collections.Generic;
namespace alptugg
{

    public class Program
    {
        static void Main(string[] args)
        {
            

            var ogrencilistesi = new List<ogrenci>()
        
            {
                new ogrenci(20,"Mehmet","Avsar", true),
                new ogrenci(30,"Yunus","ozyavuz",true),
                new ogrenci(100,"Nehir","Iskol",false)
            };

            foreach (var o in ogrencilistesi)
            {
                Console.WriteLine(o);
            }


            
            


        }

    }

    

}