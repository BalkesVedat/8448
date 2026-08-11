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




        }
    }
}
