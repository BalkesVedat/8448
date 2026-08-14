using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();

            p.AdSoyad = "Ali";
            p.TCKIMLIK = 4546546464;
            p.EkBilgi = "eerwerwe wer  rwer w";

            Ogrenci o = new Ogrenci();

            o.EkBilgi = "elrkjewlr jwelrj lwjr";
            o.TCKIMLIK = 4332232131231;
            o.AdSoyad = "aseasew qwe";


            Ucak u = new Ucak();

            u.Marka = "Boeing";
            u.YolcuSayisi = 250;
            u.Model = "777-300ER";
            u.UretimYili = 2024;

            u.BilgiVer();
            Console.WriteLine(u.UcabilirMi);


        }
    }
}
