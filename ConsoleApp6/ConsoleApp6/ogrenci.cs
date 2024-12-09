namespace alptugg
{
    public struct ogrenci
    {
        

        public ogrenci(int numara, string isim,
            string soyisim, bool cinsiyet)
        {
            Numara = numara;
            Adi = isim;
            Soyadi = soyisim;
            Cinsiyet = cinsiyet;
        }


        public int Numara { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }
        public override string ToString()
        {
            return $"{Numara} - {Adi} {Soyadi}";
        }


      



        
            

    }


    
}



