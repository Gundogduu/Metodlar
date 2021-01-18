using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string urunAdi1 = "Elma";
            double urunFiyati1 = 10;
            string aciklama = "Amasya elması";

            
            string urunAdi2 = "Çilek";
            double urunFiyati2 = 15;
            string aciklama2 = "Çilek gibi Çilek";


            Urun urun1 = new Urun();
            urun1.Id = 01;
            urun1.Adi = "Elma";
            urun1.Fiyat = 10;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Id = 02;
            urun2.Adi = "Çilek";
            urun2.Fiyat = 12;
            urun2.Aciklama = "Çilek gibi Çilek";

            Urun urun3 = new Urun();
            urun3.Id = 03;
            urun3.Adi = "Karpuz";
            urun3.Fiyat = 18;
            urun3.Aciklama = "Diyarbakır karpuzu";


            Urun[] meyveler = new Urun[] {urun1,urun2,urun3};

            
            foreach (Urun meyve in meyveler)
            {
                
                Console.WriteLine("Ürün Id: " + meyve.Id);
                Console.WriteLine("Ürün adı: " + meyve.Adi);
                Console.WriteLine("Ürün fiyatı: " + meyve.Fiyat + "tl");
                Console.WriteLine("Ürün açıklaması: " + meyve.Aciklama);
                Console.WriteLine("----------------------------");

            }

            Console.WriteLine("------------------Metodlar---------------------");
            //Instance - örnek
            //encapsulation - capsulleme : yani ayrı ayrı yazacağımız verileri tek bir yerde(classta) düzene sokmak.
            SepetManager manager = new SepetManager();
            manager.Ekle(urun1);
            manager.Ekle(urun2);
            manager.Ekle(urun3);


            //classız yöntem
            manager.Ekle2("Armut",5,"Yeşil armut",50);
            manager.Ekle2("Elma", 11, "Amasya elması",100);
            manager.Ekle2("Karpuz", 9, "Diyarbakır karpuzu",85);
        }
    }
}
