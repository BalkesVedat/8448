using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    public enum Kategori
    { 
        Gıda,         
        Elektronik,                       
        Diğer
    }

    public class Urun
    {
        public string UrunAd { get; set; }
        public double Fiyat { get; set; }
        public int Adet { get; set; }
        public Kategori kategori { get; set; }
        public double KDV { get; set; }
        public double KDVDahilTutar { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: (Iteration) Bir kodun birden fazla kere çalıştırılması gerektiğinde kurulan yapıdır.
            //For döngüsü: Bir kod için çalıştırılacak adet belli ise tercih ettiğimiz yapıdır. Çünki en hızlı çalışan yapıdır.

            Console.WriteLine("1-10 arası sayılar ---------");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" iller listesi ---------------");

            string[] iller = { "Kastamonu", "Manisa", "Adıyaman", "Konya", "Mersin", "Siirt" };

            for (int i = 0; i < iller.Length; i++)
            {
                Console.WriteLine(iller[i]);
            }

            Console.WriteLine("1-100 arası çift sayıların toplamı");

            int toplam = 0;

            //1. yöntem
            for (int i = 0; i <= 100; i += 2)
            {
                toplam += i;
            }

            //2.yöntem
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine(toplam);

            Dictionary<string, double> urunler = new Dictionary<string, double>();

            urunler.Add("domates", 150000);
            urunler.Add("havuç", 37000);
            urunler.Add("patates", 271300);
            urunler.Add("patlıcan", 19750);

            double toplamTutar = 0;

            // List<double> fiyatlar = urunler.Values.ToList();

            for (int i = 0; i < urunler.Count; i++)
            {
                //toplamTutar += fiyatlar[i];
                toplamTutar += urunler.ElementAt(i).Value;
            }

            Console.WriteLine($"Toplam işlem:{urunler.Count} Toplam tutar:{toplamTutar}");

            //-----------------------------------------------

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            //-----------------------------------------------
            //foreach : Bir kolleksiyondaki her bir değer için ayrı ayrı işlem yapılması gerektiğinde kullanılır. Her bir eleman için ayry ayrı döner ve değeri "item" değişkenine atar. kolleksiyondan gelen değerin tipi "item" ın tipi olarak atanabilir ya da "var" tipi olarak ta kullanılabilir. "var" tipi tüm tipleri kapsar. 

            foreach (string item in iller)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");

            double degerToplami = 0;

            foreach (var item in urunler.Values)
            {
                degerToplami += item;
            }

            Console.WriteLine($"Toplam işlem:{urunler.Count} Toplam tutar:{degerToplami}");

            foreach (var item in urunler.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------");

            foreach (string item in iller)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-- WHILE Döngüsü ------------- ");

            // While: Bir koşula bağlı olarak bir işlemin tekrar tekrar (koşul doğru olduğu müddetçe) yapılması gerekiyor ise, bu işlem için en uygun döngü modelidir. 

            //
            //while (koşul)
            //{
            // Koşul doğru olduğu müddetçe çalışacak işlem
            //}

            //while (true)  // Sonsuz döngü
            //{

            //}

            // Kullanıcıdan alınan 2 sayıyı toplayarak sonucunu gösteren ve kullanıcı devam etmek istediği müddetçe tekrar tekrar çalışan program

            double sayi1 = 0, sayi2 = 0, sonuc = 0;
            char cevap = 'E';

            while (cevap == 'E')
            {
                Console.Write("1. sayıyı giriniz :");
                sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. sayıyı giriniz :");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                sonuc = sayi1 + sayi2;

                Console.WriteLine($"{sayi1}+{sayi2}={sonuc}");

                Console.Write("Devam Etmek İstiyor musunuz? (E/H) : ");

                cevap = (char)(Console.ReadLine().ToUpper()[0]);

                //char[] gelenler = Console.ReadLine().ToCharArray();

                //cevap = gelenler[0];
            }

            //while (true)
            //{
            //    Console.WriteLine("Merhaba!");
            //}

            int sayac = 1;
            double toplam2 = 0;

            while (sayac <= 100)
            {
                toplam2 += sayac;
                sayac++;
            }

            Console.WriteLine($"Toplam : {toplam2}");

            Console.WriteLine("-- DO - WHILE Döngüsü  ------------- ");
            //do-while : ilk çalışmada koşul kontrolü yapmadan işlemi çalıştırır ve sonra tekrar çalışıp çalışmayavağını belirlemek için koşul kontrolü yapar. 

            //do
            //{
            // işlemler
            //} while (koşul);

            do
            {
                Console.Write("1. sayıyı giriniz :");
                sayi1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("2. sayıyı giriniz :");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                sonuc = sayi1 + sayi2;

                Console.WriteLine($"{sayi1}+{sayi2}={sonuc}");

                Console.Write("Devam Etmek İstiyor musunuz? (E/H) : ");

                cevap = (char)(Console.ReadLine().ToUpper()[0]);

                //char[] gelenler = Console.ReadLine().ToCharArray();

                //cevap = gelenler[0];
            } while (cevap == 'E');


            toplam2 = 0;
            sayac = 0;

            do
            {
                toplam2 += sayac;
                sayac++;
            }while (sayac <= 100) ;

            Console.WriteLine($"Toplam : {toplam2}");

            // ürün adı girin
            // ürün fiyatı gir
            // ürün miktarı gir 
            // kategorisini gir
            // eğer kategori
            // "gıda" ise kdv oranı 0.01 
            // "elektronik" ise kdv 0.2
            // "diğer" ise kdv 0.1 hesaplanacak
            // "yeni giriş?" sorulsun
            // "evet" ise tekrar başa dön
            // "hayır" ise girilmiş olan ürün adedi ve tüm ürünlerin kdv dahil toplam değeri ekrana yazılsın.


            //-------------------------------------

            Console.WriteLine(" Örnek -------------- : ");

            string devam = "";

            List<Urun> urunListesi = new List<Urun>();         

            do
            {
                Urun u = new Urun();

                Console.Write("Urun Adı :");
                u.UrunAd = Console.ReadLine();
                Console.Write("Urun Adedi :");
                u.Adet = Convert.ToInt32(Console.ReadLine());
                Console.Write("Urun Fiyat :");
                u.Fiyat = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Kategori (Gıda-G/Elektronik-E, Diğer-D) ? :");
                string gelen = Console.ReadLine().ToUpper();

                switch (gelen)
                {
                    case "G":
                        u.kategori = Kategori.Gıda;
                        u.KDV = 0.01;
                        u.KDVDahilTutar = u.Adet * u.Fiyat * (1 + u.KDV);
                        break;
                    case "E":
                        u.kategori = Kategori.Elektronik;
                        u.KDV = 0.2;
                        u.KDVDahilTutar = u.Adet * u.Fiyat * (1 + u.KDV);
                        break;
                    default:
                        u.KDV = 0.1;
                        u.KDVDahilTutar = u.Adet * u.Fiyat * (1 + u.KDV);
                        u.kategori = Kategori.Diğer;
                        break;
                }

                urunListesi.Add(u);

                Console.Write("Devam edilsin mi? (E/H) ");
                devam = Console.ReadLine().ToUpper();

            } while (devam=="E");

            double toplamUrunTutar = 0;
            double toplamAdet = 0;

            foreach (var item in urunListesi)
            {
                toplamUrunTutar += item.KDVDahilTutar;
                toplamAdet += item.Adet;
            }

            Console.WriteLine($"Satır:{urunListesi.Count} + Urun Adedi:{toplamAdet} - Toplam Tutar:{toplamUrunTutar} ");

            Console.ReadKey();


        }
    }
}
