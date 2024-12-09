public partial class Program
{
    public class YapilacaklarListesi
    {

        private Dictionary<int, Gorev> gorevler;
        private int mevcutId;

        public YapilacaklarListesi()
        {
            gorevler = new Dictionary<int, Gorev>();
            mevcutId = 1;
        }


        public void Gorevekle()
        {
            Console.WriteLine("Yeni gorevler ekleniyor");


            Console.WriteLine("Gorev adi:");
            string gorevAdi = Console.ReadLine();

            Console.WriteLine("gorevAciklamasi");
            string gorevAciklamasi = Console.ReadLine();

            Console.Write("Görev tamamlandı mı? (evet/hayır): ");
            bool tamamlamaDurumu = Console.ReadLine().ToLower() == "evet";


            var yeniGorev = new Gorev(mevcutId, gorevAdi, gorevAciklamasi, tamamlamaDurumu);
            gorevler.Add(mevcutId, yeniGorev);

            Console.WriteLine($"Görev başarıyla eklendi! ID: {mevcutId}");
            mevcutId++;

        }

        public Gorev GorevAra(int gorevId)
        {
            

            if (gorevler.TryGetValue(gorevId, out Gorev gorev))
            {
                return gorev;
            }
            else
            {
                Console.WriteLine("Belirttiğiniz ID bulunamadı.");
                return null;
            }
        }
        public void GorevAra()
        {
            Console.Write("Aranacak görev ID'sini girin: ");
            int gorevId;

            if (int.TryParse(Console.ReadLine(), out gorevId))
            {
                var gorev = GorevAra(gorevId); // ID ile görevi ara
                if (gorev != null)
                {
                    Console.WriteLine(gorev.ToString());
                }
            }
            else
            {
                Console.WriteLine("Geçersiz ID.");
            }
        }

        public void GorevleriListele()
        {
            if (gorevler.Count == 0)
            {
                Console.WriteLine("Mevcut gorev bulunmuyor");
                return;
            }

            // Tüm görevleri listele
            foreach (var gorev in gorevler.Values)
            {
                Console.WriteLine(gorev.ToString());
            }
        }


        public void GorevSil(int gorevId)
        {
            if (gorevler.Remove(gorevId))

            {
                Console.WriteLine($"Görev başarıyla silindi! ID: {gorevId}");
            }

            else
            {
                Console.WriteLine("Mevcut gorev bulunamadi");

            }
        }

        public void GorevTamamla(int gorevId)
        {
            var gorev = GorevAra(gorevId); // Öncelikle verilen ID ile görevi ara

            // Eğer görev bulunduysa, tamamlanma durumunu güncelle
            if (gorev != null)
            {
                gorev.TamamlamaDurumu = true; // Tamamlanma durumunu true yap
                Console.WriteLine("Görev başarıyla tamamlandı!");
            }
            else
            {
                Console.WriteLine("Mevcut görev bulunamadı.");
            }
        }
    }


}
