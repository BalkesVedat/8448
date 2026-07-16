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


          


        }
    }
}
