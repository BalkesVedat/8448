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
            otomobil._silindirSayisi = 12;
            otomobil._yakitTipi = YakitTipi.Benzin;
            otomobil._yakitHacmi = 500;
            otomobil._motorSaseNo = "12321X21321W2342";


            Console.WriteLine(otomobil._silindirSayisi);

            Console.WriteLine(otomobil._yakitTipi);
            Console.WriteLine(otomobil._yakitHacmi);
            Console.WriteLine(otomobil._motorSaseNo);

            otomobil._motorSaseNo = "E555555K4545555C";

            Console.WriteLine(otomobil._motorSaseNo);


        }
    }
}
