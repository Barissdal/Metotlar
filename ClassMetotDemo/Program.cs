using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            Musteri musteri2 = new Musteri();
            
            MusteriManager musteriManager = new MusteriManager();

            musteri1.Adi = "Barış";
            musteri1.Soyadi = "Doğan";
            musteri1.MusteriNo = 111111;
            musteri1.KrediTutarı = 62000;


            musteri2.Adi = "Barış";
            musteri2.Soyadi = "Doğu";
            musteri2.MusteriNo = 111111;
            musteri2.KrediTutarı = 2000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };


            int islem = 0;
            
            Console.WriteLine("1-Müşterileri Ekleme.");
            Console.WriteLine("2-Müşterileri Listeleme.");
            Console.WriteLine("3-Müşterileri Silme.");
            Console.WriteLine("4-Çıkış.");
            


            while(islem != 4)
            {
                Console.WriteLine("Bir işlem seçiniz.");
                islem = Convert.ToInt16(Console.ReadLine());
                if (islem == 1)
                {
                    musteriManager.MusteriEkle(musteri1);
                    musteriManager.MusteriEkle(musteri2);
                } 
                else if(islem == 2)
                {
                    musteriManager.MusteriListeleme(musteriler);
                }
                else if( islem == 3)
                {
                    Console.WriteLine("Kaydınız silindi");
                }
                else
                {
                    Console.WriteLine("Teşekkür ederiz.");
                }
                
            }

        }
    }
}
