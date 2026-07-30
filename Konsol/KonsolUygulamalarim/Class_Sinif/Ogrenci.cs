using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sinif
{
    class Ogrenci
    {
        public int OgrNo;
        public string AdSoyad;
        public int Yas;
        public Cinsiyet Cinsiyeti;
        public DateTime KayitTarihi;

        public Ogrenci()
        {
            KayitTarihi = DateTime.Now;
        }

        public Ogrenci(int _OgrNo, string _AdSoyad, int _Yas, Cinsiyet _Cinsiyeti)
        { 
            OgrNo = _OgrNo;
            AdSoyad = _AdSoyad;
            Yas = _Yas;
            Cinsiyeti = _Cinsiyeti;
        }


    }
}
