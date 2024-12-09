public partial class Program
{
    public class Gorev
    {
        // Konstrüktör
        public Gorev(int gorevId, string gorevAdi, string gorevAciklamasi, bool tamamlamaDurumu)
        {
            GorevId = gorevId;
            GorevAdi = gorevAdi;
            GorevAciklamasi = gorevAciklamasi;
            TamamlamaDurumu = tamamlamaDurumu;
        }

        // Özellikler
        public int GorevId { get; set; }
        public string GorevAdi { get; set; }
        public string GorevAciklamasi { get; set; }
        public bool TamamlamaDurumu { get; set; }

        // ToString metodu
        public override string ToString()
        {
            return $"{GorevAdi,-30} {GorevAciklamasi,-50} {(TamamlamaDurumu ? "Tamamlandı" : "Tamamlanmadı")}";
        }
    }


}
