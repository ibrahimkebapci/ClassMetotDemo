using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "ali";
            musteri1.Soyad = "Atar";
            musteri1.MusteriId = 224;
         
            Musteri musteri2 = new Musteri();
            musteri2.Ad = "veli";
            musteri2.Soyad = "Balcı";
            musteri2.MusteriId = 113;
            
            Musteri musteri3 = new Musteri();
            musteri3.Ad = "arif";
            musteri3.Soyad = "kalender";
            musteri3.MusteriId = 556;
           

            Musteri[] Musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager MetotTasiyici = new MusteriManager();
            MetotTasiyici.MusteriEkle(Musteriler[0]);
            MetotTasiyici.MusteriListele(Musteriler[1]);
            MetotTasiyici.MusteriSil(Musteriler[2]);



        }
    }
}
