using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele (Musteri x)
        {
            Console.WriteLine(x.Ad);
            Console.WriteLine(x.Soyad);
            Console.WriteLine(x.MusteriId);
            Console.WriteLine("---------------------------");
        }
        public void MusteriEkle(Musteri x)
        {
            Console.WriteLine("Musteri verileri siliniyor");
            Console.WriteLine("Musteri ad: " + x.Ad);
            Console.WriteLine("Musteri Soyad: " + x.Soyad);
            Console.WriteLine("Musteri Id: " + x.MusteriId);
            Console.WriteLine("---------------------------");
        }
        public void MusteriSil(Musteri x)
        {
            Console.WriteLine("Musteri verileri Ekleniyor");
            Console.WriteLine("Musteri ad: " + x.Ad);
            Console.WriteLine("Musteri Soyad: " + x.Soyad);
            Console.WriteLine("Musteri Id: " + x.MusteriId);
            Console.WriteLine("---------------------------");
        }
    }
}
