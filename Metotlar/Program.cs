using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "Amasya Elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Product[] urunler = new Product[] { urun1,urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Fiyatı + " " + urun.Aciklama + Environment.NewLine);
            }

            Console.WriteLine("---------------Metotlar-------------");

            // instance -örnek
            SepetManager sepetManager = new SepetManager();
            // encapsulation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut","Yeşil Armut",12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 5, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80, 8);
        }
    }
}
