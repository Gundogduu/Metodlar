using System;

namespace DegerveReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi ?? cevap:30



            int[] sayilar1 = new int[] {10,20,30};
            int[] sayilar2 = new int[] { 100, 200, 300};
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? cevap: 999
        }
    }
}
//DEGER TIP
// int,double,float,decimal,bool gibi sayısal veri tipleri
//bu arada bool 0 ve 1 döndürür arka planda.

//REFERANS TIP
//array, class, interface
//bu arada int array olmasının bir onemi yok,tum arrayler referans tiptip.