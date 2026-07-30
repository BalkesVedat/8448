using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sinif
{
    internal class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string Marka { get; set; }


        private double fiyat;

        public double Fiyat
        {
            get { return fiyat; }
            set {           
                fiyat = value; 
                KDVDahilFiyat = fiyat*1.2;
            }
        }


        public double Maliyet { get; set; }
        public double KDVDahilFiyat { get; set; }

        public Urun()
        {
            Console.WriteLine("Ürün oluşturuldu.");
        }

        public Urun(int urunID, string urunAdi, string marka, double fiyat, double maliyet)
        {
            UrunID = urunID;
            UrunAdi = urunAdi;
            Marka = marka;
            Fiyat = fiyat;
            Maliyet = maliyet;
            //KDVDahilFiyat = fiyat*1.2;
        }

        public void UrunKaydet()
        {
            Console.WriteLine("Urun Kaydedildi");
        }

        public void UrunSil()
        {
            Console.WriteLine("Urun Silindi");
        }

        public void BilgiVer()
        {
            Console.WriteLine("Urun Kodu:{0}",UrunID);
            Console.WriteLine("Urun Adı:{0}", UrunAdi);
            Console.WriteLine("Urun Marka:{0}", Marka);
            Console.WriteLine("Urun Fiyat:{0}", Fiyat);
            Console.WriteLine("Urun Maliyet:{0}", Maliyet);
            Console.WriteLine("Urun KDV Dahil Fiyat:{0}", KDVDahilFiyat);
        }

    }
}
