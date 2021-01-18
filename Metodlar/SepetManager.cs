using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        Urun urun = new Urun();
        public void Ekle(Urun urun)            //Urun class'ından özellikleri cekiyor.Bu yöntemde yeni bir özellik eklemek gerektiğinde 
        {                                                                                 //sadece Urun classından islem yapmak yeterli.
            Console.WriteLine("Sepete eklendi : " + urun.Adi);
            
        }

        public void Ekle2(string urunAdi,double fiyati,string aciklama,int stokAdedi)       //özellikleri parametre olarak parantez icine yazmak zorundayız.
        {                                                                                   //bu yöntemde ise yeni özellik eklemek icin bir çok yeri degistirmek gerekiyor.
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
