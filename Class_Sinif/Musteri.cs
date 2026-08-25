using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sinif
{
    internal class Musteri
    {
        public Musteri()
        {
            
        }

        public Musteri(string _musteriAdSoyad, string _firmaAdi, string _adresi, string _eMail)
        {
            musteriAdSoyad = _musteriAdSoyad;
            firmaAdi = _firmaAdi;
            adresi = _adresi;
            eMail = _eMail;
        }


        //fields : Alanlar
        public int musteriID;
        public string musteriAdSoyad,firmaAdi,adresi,eMail;
        public byte musteriTipi;
        public int telefon;
        private byte durum = 0;
        private DateTime kayitTarihi=DateTime.Now;

        //methods : metodlar - işlem yapan kod parçaları

        public string GetCustomerStatus() {
            //işlem kodları

            if (durum == 0)
                return "Pasif";
            else
                return "Aktif";
        }

        public void SetCustomerStatus(byte bilgi) {
            if (bilgi==0 || bilgi==1)
            {   
                durum = bilgi;
            }     
        }

        public DateTime GetKayitTarihi() {       
            return kayitTarihi;      
        }




    }
}
