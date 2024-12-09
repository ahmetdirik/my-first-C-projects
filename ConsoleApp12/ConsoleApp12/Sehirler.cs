namespace BTKAkademi.ProgramlamaTemelleri
{


    public class Sehir : IComparable<Sehir>
    {
        public Sehir(int plakaNo, string sehirAdi)
        {
            PlakaNo = plakaNo;
            SehirAdi = sehirAdi;
        }

        public override string ToString()
        {
            return $"{PlakaNo},{SehirAdi}";
        }

        public int CompareTo(Sehir other)
        {
            if (this.PlakaNo < other.PlakaNo)
            {
                return -1;
            }

            else if (this.PlakaNo == other.PlakaNo)
            {
                return 0;
            }

            else
            {
                return 1 ;
            }
        }

        public int PlakaNo { get; set; }

        public string SehirAdi { get; set; }

        
    }
}