using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arayüz : (Interface) Daha önce nesne üretmek için class'lar yapmıştık. Class nesnenin şablonuna denir. Class'ların nasıl yazılacağını tarif eden şablonlara da Interface diyoruz. Yani uygulamanın altyapısı (mimarisi-Infrastructure) hazırlanırken yazılımcıların uygulamadaki sınıfları ve alt sınıfları nasıl yazacaklarını tarif etmek için şablon olarak interface'ler üretilir. Bu interface'i uygulayan bir class, interface içerisindeki tüm property'leri ve metodları içermek (implementasyon) zorundadır. Interface içinde tarif edilen metodlar, metod gövdesine sahip değildir, gövdeleri bu interface i uygulayan class içerisinde yazılır. (Abstract metodlar gibi)
            //Interface'ler sadece şablon niteliği taşıdığından nesne örneği almak için kullanılmaz.
            //örn: IAraba a1 = new IAraba(); yazılamaz.
            //Constructor içermez. Çünki nesne üretemez.
            //Interface ismi verirken "I" harfi ile başlatırız. 
            // Örn: IAraba, ICanli, IUcabilir, IEnumerable v.b.
            //Bir sınıf birden fazla Interface'i uygulayabilir.
            //Örn: internal class Otomobil :Tasit,IAraba,IUcabilir { }

            Otomobil ferrari = new Otomobil();
            ferrari.Marka = "Ferrari";
            ferrari.Model = "F1";

           ferrari.Calistir();
           ferrari.Yavasla();

            if (ferrari.YakitVarMi())
            { 
                
            }

        }
    }
}
