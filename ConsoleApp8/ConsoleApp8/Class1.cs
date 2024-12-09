using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class OgretimElemani
    {
        public int Sicil { get; set; }
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public bool Cinsiyet { get; set; }



        public OgretimElemani()
        {
            System.Console.WriteLine("otomatik calisti");   
        }

        public OgretimElemani(int sicil, string adi, string soyadi, bool cinsiyet)
        {
            Sicil = sicil;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public override string ToString()
        {
            return $"{Sicil,-5}" +
                $"{Adi,-10}" +
                $"{Soyadi,-10}"+
                String.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
               
               

        }
    }
}
