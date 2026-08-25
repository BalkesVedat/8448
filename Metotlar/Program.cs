using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Test
    {

        void Cagir()
        {
            Program.MesajVer();
        
        }
        
    
    }




    class Program
    {
        internal static void MesajVer()
        {
            Console.WriteLine("Hellloooo...");
        }

        internal static void MesajVer(string text) //dışarıdan string tipinde bir parametre alıp kullanacak overload (aşırı yüklenmiş) versiyon
        {
            if (text != string.Empty)
                Console.WriteLine(text);
        }
        internal static double Topla(double s1, double s2)
        {
              return s1+s2; // void olmayan metodlar em son satırında "return" ifadesi içermelidir. return ile döndürülen verinin tipi metod tanımında yazılan tipte olmalıdır.  

           // Console.WriteLine("eerterter"); return den sonraki kodlar çalışmaz.

        }

        void ZamanBilgisiVer()
        {
            Console.WriteLine(DateTime.Now);
        }


        static void Main(string[] args)
        {
            #region Metod Notları
            //Metodlar, belirli bir işi yapan kodlardır.
            //Tekrar tekrar kullanılabilirler. Reusable 
            // Gerektiği yerde çağırılarak kullanılabilirler.
            // Bir metod tek bir işi yapmaktan sorumlu olmalıdır. Single Responsibility

            // Metodlar sadece class seviyesinde yazılabilirler.
            // İçinde yazıldıkları class'ın nesne örneğinde bir metodun bulunmasını istemiyorsak, o metodu "static" metod olarak yaratmaliyız.
            // Static metodlar nesne örneğine taşınmaz, doğrudan class ismi ile çağırılırlar. 

            //Bazı metodlar işlemek için ekstra bilgiye ihtiyaç duyar. Bu bilgiler metoda çalışacağı zaman verilir. Metoda bu bilgileri aktarmak için metod parametrik yazılır. Yani metod parantezi içerinde dışarıdan gelecek bilgilerin tipi ve içerisine aktarılacağı değişken adı tanımlanır.

            // Parametrik metodlar: Dışarıdan istediğimiz tipte ve sayıda değer alıp, işleyebilen metodlardır.
            // Geri değer döndüren metodlar: Bir metod geri değer döndürmüyorsa "void" olarak işaretlenir. Bir değer geri dönecekse, void yerine dönecek bilginin tipi yazılır ve metodun son satırında "return" ifadesi ile bilgi döndürülür. 


            #endregion

            Program p1 = new Program(); // Class'ın nesne örneği alarak heap belleğe çıkarttık. 

            MesajVer(); // static tanımlandığı için ismiyle çağırılabilir. Belleğin static kısmında yer alıyor.

            MesajVer("Mesaj1");
            MesajVer("Günaydın");
            MesajVer("asdasdas");

            p1.ZamanBilgisiVer(); // static olmadığı için belleğe sadece nesne örneği alınarak çıkartılıp çağırılabilir. O yüzden Program class ının nesne örneğini alarak çağırabildik.

            double x = Topla(155, 100);

            if (x < 0)
            {

            }

            Console.WriteLine(x);

            if (Topla(500,300)>0)
            {

            }

            double y = 3.75 * Topla(250,0.2);


           // Topla(50,75);

        }
    }
}
