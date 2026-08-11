using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: (Iteration) Bir kodun birden fazla kere çalıştırılması gerektiğinde kurulan yapıdır.
            //For döngüsü: Bir kod için çalıştırılacak adet belli ise tercih ettiğimiz yapıdır. Çünki en hızlı çalışan yapıdır.

            Console.WriteLine("1-10 arası sayılar ---------");
            
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" iller listesi ---------------");

            string[] iller = {"Kastamonu", "Manisa", "Adıyaman", "Konya", "Mersin", "Siirt" };

            for (int i = 0; i < iller.Length; i++)
            {
                Console.WriteLine(iller[i]);
            }

            Console.WriteLine("1-100 arası çift sayıların toplamı");

            int toplam = 0;

            //1. yöntem
            for (int i = 0; i <= 100; i+=2)
            {
                toplam += i;
            }

            //2.yöntem
            for (int i = 0; i <= 100; i++) 
            {
                if (i%2==0)
                {
                    toplam += i;
                }
            }

            Console.WriteLine(toplam);

            Dictionary<string,double> urunler = new Dictionary<string,double>();

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



        }
    }
}
