using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Soyutlama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();

            o1.KisiID = 1;
            o1.AdSoyad = "Ali Ak";
            o1.EMail = "ali@ali.com";

            o1.KisiKaydet();

            o1.BilgiVer();

            o1.KisiSil(1);

            Console.WriteLine("-------------------------------");

            Memur m1 = new Memur();

            m1.KisiID = 2;
            m1.AdSoyad = "Ayşe Kara";
            m1.EMail = "aaa@ccc.com";

            m1.KisiKaydet();
            m1.BilgiVer();


        }
    }
}
