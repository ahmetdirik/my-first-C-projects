namespace alptugg
{
    public class Personel
    {
        public Personel(string adi, string soyAdi, decimal maas)
        {
            Adi = adi;
            SoyAdi = soyAdi;
            Maas = maas;
        }

        public int SicilNo { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public decimal Maas { get; set; }

        public override string ToString()
        {
            return $"{Adi,-10} {SoyAdi,-15} {Maas,-10}";
        }

    }
}