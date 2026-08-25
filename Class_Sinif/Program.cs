using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sinif
{
    enum Cinsiyet
    {
        Kadın,
        Erkek
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();

            Ogrenci o2 = new Ogrenci(25, "Ali", 16, Cinsiyet.Erkek);

            Musteri m = new Musteri();

            m.musteriID = 1;
            m.musteriAdSoyad = "Ali Kılıç";
            m.adresi = "şldsfkşskşfkşlf şlk şlk şlkşl şlk şlkşlkşlkşlk Bakırköy";
            m.eMail = "fsdfsdf@fgdfgd.com";

            DateTime gelenTarih = m.GetKayitTarihi();

            string xx = m.GetCustomerStatus();

            m.SetCustomerStatus(250);

            Console.WriteLine(m.GetCustomerStatus());
            Console.WriteLine(m.GetKayitTarihi());


          Tasit otomobil = new Tasit();

            otomobil._plaka = "34 ABC 34";
            otomobil._marka = "Mercedes";
            otomobil._model = "CLK 500";
           // otomobil._silindirSayisi = 12;
            otomobil._yakitTipi = YakitTipi.Benzin;
            otomobil._yakitHacmi = 500;
            otomobil._motorSaseNo = "12321X21321W2342";


            Console.WriteLine("Silindir Sayısı:{0}",otomobil._silindirSayisi);

            Console.WriteLine(otomobil._yakitTipi);
            Console.WriteLine(otomobil._yakitHacmi);
            Console.WriteLine(otomobil._motorSaseNo);

            otomobil._motorSaseNo = "E555555K4545555C";

            Console.WriteLine(otomobil._motorSaseNo);

            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("o1 in kayıt tarihi:{0}", o1.KayitTarihi);
            Console.WriteLine("o2 in kayıt tarihi:{0}", o2.KayitTarihi);


            Tasit otobus = new Tasit("34 AS 222");
            Ogrenci ali = new Ogrenci();
            Ogrenci veli = new Ogrenci(10, "Veli", 17, Cinsiyet.Erkek);

            Urun urun = new Urun();

            Urun u1 = new Urun(456, "CLK 500 Otomobil", "Mercedes", 23.7, 12.15);

            urun.Fiyat = 175.18;

            u1.Fiyat = 50; // set metodu KDV dahil fiyatı hesaplıyor.

            //urun.KDVDahilFiyat = urun.Fiyat * 1.2

            Console.WriteLine($"u1 KDV Dahil Fiyatı:{u1.KDVDahilFiyat}");

            u1.BilgiVer();

        }
    }
}
