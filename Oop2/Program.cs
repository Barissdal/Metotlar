using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();

            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demir";
            //musteri1.Id = 1;
            //musteri1.TcNo = "222222";
            //musteri1.MusteriNo = "11111";
            //// gerçek kişinin şirket adi yoktur burada soyutlama hatası oluşmaktadır.
            //musteri1.SirketAdi = "?";

            // Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demir";
            musteri1.TcNo = "2222222";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "KodlamaIo";
            musteri2.VergiNo = "98765432";

            // new gördüğümüzde referans numarası aklıma gelmeli
            // Burada musteri hem gerçek hem tuzel musteriyi tutabiliyor.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
            customerManager.Ekle(musteri3);
            customerManager.Ekle(musteri4);


        }
    }
}
