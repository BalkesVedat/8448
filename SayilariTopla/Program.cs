using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayilariTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 500; 

            int sayi2 = 600;
            int toplam = 0;

            Console.WriteLine(toplam);

            toplam = sayi1 + sayi2;

            Console.WriteLine(sayi1 + " ile " + sayi2 + " sayılarının toplamı = " + toplam);

            Console.WriteLine("-----------------------------------------------------------");

            Console.Write("1. Sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine(sayi1 + " ile " + sayi2 + " sayılarının toplamı = " + toplam);

            Console.ReadKey();
        }
    }
}
