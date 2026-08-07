using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programın çalışması esnasında bir kaşula göre programın farklı işlemlerden birini yapması gerektiğinde bu yapılar kullanılır. en çok kullanılan mekanizmalar : if/else, if/else if/else, switch/case 

            // if / else : Eğer 2 durumlu bir seçime göre işlem yapılacaksa (true-false) en uygun yapıdır.

            int yas = 15;
            string currency = "EUR";
            double tutar = 1500;
            double tlTutar = 0;
            double gunlukUSDKur = 47.5;
            double gunlukEURKur = 55.2;
            double gunlukYENKur = 0.3;


            if (yas < 18) // koşul karşılaştırma ifadesi
            {
                // karşılaştırma ifadesi true ise yapılacak işlem
                Console.WriteLine("18 yaşından küçükler sisteme kaydolamaz.");
            }
            else
            {
                // karşılaştırma ifadesi false ise yapılacak işlem
                Console.WriteLine("Yaşınız uygun.");
            }

            //---------------------------------------------------------------
            if (yas < 18)
                Console.WriteLine("18 yaşından küçükler sisteme kaydolamaz.");
            else
                Console.WriteLine("Yaşınız uygun.");
            //---------------------------------------------------

            if (currency == "USD")
            {
                tlTutar = tutar * gunlukUSDKur;
            }
            else
            {
                tlTutar = tutar;
            }

            //---------------------------------------------
            // işin içine 3., 4., 5., ... v.b. başka ihtimaller de girdiğinde if/else yapısı yetersiz kalıyor. 3. ihtimalin de kontrolü gerekiyor. bu durumda if / else if / else yapısını kullnıyoruz.

            // if / else if / else :

            if (true) //koşul 1
            { } // koşul 1 doğru ise yapılacak işlem
            else if (true) // koşul2
            { } // koşul 2 doğru ise yapılacak işlem
            else if (true) // koşul 3
            { } // koşul 3 doğru ise yapılacak işlem
            //....
            else
            { } //yukarıdaki koşulların hiç biri doğru değilse yapılacak işlem.

            //------------------------------------------------------

            if (currency == "USD")
                tlTutar = tutar * gunlukUSDKur;
            else if (currency == "EUR")
                tlTutar = tutar * gunlukEURKur;
            else if (currency == "YEN")
                tlTutar = tutar * gunlukYENKur;
            else
                tlTutar = tutar;

            Console.WriteLine($"Tutar:{tutar} - ParaBirimi:{currency} - TL Karşılığı:{tlTutar}");

            //--- IF / ELSE IF / ELSE   ÖRNEĞİ  ------------------------
            // 1. kullanıcıdan not bilgisi alınacak
            // 2. gelen değer sayısal değere dönüştürülecek
            // 3. gelen değer kontrol edilecek:
            //a. 20 den küçükse harf notu "F" olacak
            //b. 40 tan küçükse "E"
            //c. 60 tan küçükse "D"
            //d. 80 den küçükse "C"
            //e. 90 dan küçükse "B"
            //f. değilse "A" olsun.
            //4. Sonucu (Girilen notu ve harf karşılığını) ekrana yaz.
            //---------------------------------------------------------
            Console.Write("Notu giriniz:");
            int girilenNot = Convert.ToInt32(Console.ReadLine());

            if (girilenNot < 20)
                Console.WriteLine($"Girilen Not:{girilenNot} - Harf: F ");
            else if (girilenNot < 40)
                Console.WriteLine($"Girilen Not:{girilenNot} - Harf: E ");
            else if (girilenNot < 60)
                Console.WriteLine($"Girilen Not:{girilenNot} - Harf: D ");
            else if (girilenNot < 80)
                Console.WriteLine($"Girilen Not:{girilenNot} - Harf: C ");
            else if (girilenNot < 90)
                Console.WriteLine($"Girilen Not:{girilenNot} - Harf: B ");
            else
                Console.WriteLine($"Girilen Not:{girilenNot} - Harf: A ");

            // switch - case : Kontrol edilecek durumun 2 den fazla olması durumunda if - else if yerine switch-case de kullanabiliriz. Bu yapı genellikle bir değişkenin alabileceği farklı değerlere göre farklı işlem yapılmak istendiğinde kullanılabilir.

            switch (currency)  // değeri kontrol edilecek değişken
                {
                    case "USD":
                        tlTutar = tutar * gunlukUSDKur;
                        break;
                    case "EUR":
                        tlTutar = tutar * gunlukEURKur;
                        break;
                    case "YEN":
                        tlTutar = tutar * gunlukYENKur;
                        break;
                    default:
                        tlTutar = tutar;
                        break;
                }

        // switch - case örneği : ödev.
        // 1. menü gösterilsin.
        //    a. Para çekme
        //    b. Para yatırma
        //    c. havale / eft
        //    d. çıkış
        // 2. seçim istensin
        // 3. seçime göre ilgi işlem menüleri açılsın.

        //ödev2: if-else if ile hıza göre ceza heaplayan program
        /* 
              0-20 km arası : 500 TL
             20-95 km arası ceza yok
            96-110 km arası :1000 TL
            111-135 km arası :2000 TL
            >135 km 5000 TL ve aracı bağla.
         */


        }
    }
}
