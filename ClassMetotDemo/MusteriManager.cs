using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Bilgileri Sisteme Eklendi:");
            Console.WriteLine("Adı:" + musteri.Adi);
            Console.WriteLine("Soyadı:" + musteri.Soyadi);
            Console.WriteLine("Müsteri No:" + musteri.MusteriNo);
            Console.WriteLine("Kredi Tutarı:" + musteri.KrediTutarı);
        }

        public void MusteriListeleme(Musteri[] musteriler)
        {
            Console.WriteLine("Müsteri Bilgileri Listeleniyor");

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " " + musteri.MusteriNo + " "  + 
                    musteri.KrediTutarı + Environment.NewLine);
            }
        }
    }
}
