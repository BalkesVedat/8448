using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    enum Renkler
    {
        Mavi=1,
        Kırmızı,
        Sarı,
        Turuncu,
        Yeşil,
        Siyah
    }

    struct Urun
    { 
       internal int UrunKod;
       internal string UrunAd;
       internal double Fiyat;
       internal Renkler UrunRengi;
    }

    struct Ogrenci
    { 
        public int OgrenciKod;
        public string OgrenciAd;
        public int OgrenciSinifi;
        public DateTime OgrenciKayitTarihi;
    }


    internal class Program
    {
        enum Hobiler
        {
            Kitap=100, Resim=200, Müzik=150, Satranc=5, Gezi
        }

        enum Status
        { 
            YeniKayit=0,Mezun=1,KayitDondurdu=3,KaydiSilindi=5        
        }

        enum Mezuniyet
        { 
            ilkOkul=1,
            OrtaOkul,
            Lise,
            Yüksekokul,
            Lisans,
            Master,
            Doktora   
        }


        static void Main(string[] args)
        {
            // Variables(Değişkenler) : Değişken, bilgisayarın RAM belleğinde programın çalışması esnasında geçici süreliğine bekletilmesi gereken bilgileri tutmak için kullanılan bellek alanlarıdır. Bu alanlar içerisinde, sayısal, metinsel, tarihsel, mantıksal, v.b. tipinde veriler tutulabilir ve ihtiyaç duyuldukça tutulan verilen bu bellek alanlarından tekrar çağırılarak kullanılır. Her farklı tipteki veri için, farklı tipte değişken kullanılır.

            // Değişken Tipleri :
            // Verinin Tutulduğu yer ve tutulma biçimine göre temel olarak 2 tip değişken vardır. Değer Tipli (Value Type) ve Referans Tipli (Reference Type) değişkenler.

            // 1. Değer Tipli değişkenler: Belleğin stack kısmında oluşturulurlar ve içlerinde verinin kendisini tutarlar. Değer Tipli değişkenler, Tam Sayı Değişkenler, Ondalıklı Sayı Değişkenleri, Mantıksal (Boolean) değişken, Enum, Struct v.b. Sayılabilir. Değer tipli değişkenlere değer ataması yapılmadan kullanılamaz.
            // a. Tam Sayı Değişken Tipleri: byte, short, int, long
            // b. Ondalıklı sayı tipleri : float, double, decimal
            // c. Mantıksal veri Tipi : bool - (true/false)
            // d. Enum: Enumerator : Numaralayıcı (Seçenek Listesi yapar)
            // e. Struct (yapı) : Bir yada birden fazla farklı bilgiyi bir arada tutabilen kendi tipimizi tanımlamak için kullanabileceğimiz değişken tipidir. Max 16 byte için önerilir.
            // f. Tarih/Saat veri tipi
            // g. char - karakter veri tipi: içerisinde tek 1 tane karakter tutar.

            // a.Tamsayılar:
            byte vizeNotu;
            // Console.WriteLine(vizeNotu); Değer ataması henüz yapılmadığı için hata verir.

            vizeNotu = 0;
            Console.WriteLine(vizeNotu);

            ushort maas = 60000;
            short maas2 = -32000;
            int maas3 = -60000;

            long fiyat = 10000000000;

            //b. Ondalıklı Sayılar:
            float f = 100.1f;
            double urunFiyati = (double)maas;
            decimal not = 3.67M;

            //c. boolean - true/false
            bool devam = true;
            bool cevap = 5 < 3;
            bool kontrol = fiyat <= 0;


            //d.enum : numaralandırıcı - seçenek listesi (özel tip)

            Hobiler ogrenciHobi = Hobiler.Satranc;

            // Status s = Status.YeniKayit;

            int durum = 5;

            bool esitMi = durum == (int)Status.KaydiSilindi;

            if (esitMi)
            {

            }

            //e.struct (Yapı) : Özel tip tanımlamk için kullanılır.

            Urun urun1 = new Urun();

            urun1.UrunKod = 1;
            urun1.UrunAd = "Bisküvi";
            urun1.Fiyat = 55.75;

            //f. DateTime  tipi: Tarih tipinde verier tutmak için kullanılır.

            DateTime tarih = Convert.ToDateTime("2026-06-01");
            DateTime satisTarihi = DateTime.MinValue;
            DateTime kayitTarihi = new DateTime(2026, 3, 19);


            //g. char

            char karakter = 'A';
            char k2 = '6';
            char k3 = (char)169;


            Console.WriteLine(k3 + " ---------------------------------");

            int vize = 0, final = 0;
            double sonuc = 0;

            Console.Write("Vize Notunu Giriniz:");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunu Giriniz:");
            final = Convert.ToInt32(Console.ReadLine());

            sonuc = vize * 0.4 + final * 0.6;

            if (sonuc < 70)
                Console.WriteLine("KÖTÜ");
            else
                Console.WriteLine("İYİ");

            Console.WriteLine("-----------------------------------------");

            Urun ceket = new Urun();

            ceket.UrunKod = 128;
            ceket.UrunAd = "kanvas kareli ceket siyah";
            ceket.Fiyat = 11250.5;
            //  ceket.UrunRengi = Renkler.Siyah;
            ceket.UrunRengi = (Renkler)6;

            Console.WriteLine(ceket.UrunAd + " - " + ceket.Fiyat + " - " + ceket.UrunRengi);

            Console.WriteLine("{0} - {1} - {2}", ceket.UrunAd, ceket.Fiyat, ceket.UrunRengi);

            Console.WriteLine($"{ceket.UrunAd} - {ceket.Fiyat} - {ceket.UrunRengi}");


            Console.WriteLine("-------------------------------------------------------------------");


            // 2. Referans Tipli Değişkenler : İçlerinde veri yerine, verinin bellekteki yerinin adresini tutan değişkenlerdir. Değişkenin kendisi belleğin "stack" kısmındadır. İşaret ettiği veri ise belleğin "heap" bölgesindedir. String, array, kolleksiyonlar, class, delegate, interface

            string adSoyad = "Ali Ak";
            string adres = "Bakçelievler";
            string secim = "A";


            //Array : dizi - içerisinde aynı tipte 1 den fazla veri taşıyabilen yapılardır.

            int[] sayilar = { 5, 25, 5000, 3, 3000000, 18 };

            string[] iller = new string[82];
            iller[5] = "Adıyaman";

            iller[34] = "istanbul";
            iller[0] = "Boş";



            Console.ReadKey();

        }
    }
}
