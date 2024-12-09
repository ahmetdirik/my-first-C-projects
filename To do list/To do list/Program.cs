using System;
using System.Collections.Generic;
public partial class Program
{
    static void Main(string[] args)
    {
        YapilacaklarListesi yapilacaklarListesi = new YapilacaklarListesi();

        Console.WriteLine("To-do list uygulamasına hoş geldiniz.");

        bool devam = true;

        while (devam)
        {
            Console.WriteLine("\nNe yapmak istersiniz?");
            Console.WriteLine("1 - Mevcut listeye eriş.");
            Console.WriteLine("2 - Listeye yeni görev ekle.");
            Console.WriteLine("3 - Listedeki görevi ara.");
            Console.WriteLine("4 - Listeden görev sil.");
            Console.WriteLine("5 - Listedeki görevlerin tamamlanmalarını ayarla.");
            Console.WriteLine("6 - Çıkış");
            Console.Write("Seçiminiz: ");

            int komut;
            if (!int.TryParse(Console.ReadLine(), out komut))
            {
                Console.WriteLine("Geçersiz komut, lütfen tekrar deneyin.");
                continue;
            }

            switch (komut)
            {
                case 1:
                    Console.WriteLine("Mevcut listeye erişiliyor...");
                    yapilacaklarListesi.GorevleriListele();
                    break;

                case 2:
                    Console.WriteLine("Yeni görev ekleniyor...");
                    yapilacaklarListesi.Gorevekle();
                    break;

                case 3:
                    Console.WriteLine("Görev aranıyor...");
                    yapilacaklarListesi.GorevAra();
                    break;

                case 4:
                    Console.WriteLine("Görev siliniyor...");
                    Console.Write("Silmek istediğiniz görev ID'sini girin: ");
                    int silId;
                    if (int.TryParse(Console.ReadLine(), out silId))
                    {
                        yapilacaklarListesi.GorevSil(silId);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ID.");
                    }
                    break;

                case 5:
                    Console.Write("Tamamlamak istediğiniz görev ID'sini girin: ");
                    int tamamlaId;
                    if (int.TryParse(Console.ReadLine(), out tamamlaId))
                    {
                        yapilacaklarListesi.GorevTamamla(tamamlaId);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz ID.");
                    }
                    break;

                case 6:
                    Console.WriteLine("Çıkış yapılıyor...");
                    devam = false; // Döngüden çıkış yap
                    break;

                default:
                    Console.WriteLine("Geçersiz komut");
                    break;
            }

            Console.ReadKey();
        }
    }


}
