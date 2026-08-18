using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kapsulleme
{
    internal class Arac //Aynı projeden erişilebilir - internal
    {
        //public int aracID;

        // string marka; // marka field ına dışarıdan erişim istemiyoruz. Bu nedenle property üzerinden erişeceğiz.
        public string Marka { get; set; } // Marka girişi doğrudan bu property üzerinden yapılacak.

        // alternaif kullanım. 
        private string model;  // field'ı private yaparak erişime kapatıyoruz ve ona erişim için public bir property yazıyoruz. Değer okuma ve değer atama işlemlerini property'nin get ve set metodları ile yapıyoruz.
        public string Model
        {
            get { return model; } // değeri okunduğunda
            set { model = value; } // değer atanmak istendiğinde       
        }

        // prop ve propfull kestirme komutlarıyla hızlıca property oluşturulabilir. prop ile field'ı gizli property, propfull ile filed'ı görünen ve istenirse get ve set metodları özelleştirilebilen full property oluşturulur.

        // get ve set'i özelleştirilmiş property :

        private int maximumHiz;

        public int MaximumHiz
        {
            get { return maximumHiz; }
            set
            {
                if (value < 0)
                    maximumHiz = 0;
                else
                    maximumHiz = value;
            }
        }

        // Set metodunda gelen value değeri kontrol edilerek duruma göre değer ataması yapılabilir ya da atanmak istenen değer engellenebilir. Özel başka bir değer atanabilir. Hatta set metodu silinerek ilgili property'ye değer ataması tamamen engellenebilir. Bu durumda property "readonly" olur.
        // Get metodunu özelleştirerek te, field taki veri değiştirilerek döndürülebilir.


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Arac a = new Arac();

            a.Marka = "Mercedes";
            a.Model = "E200";
            a.MaximumHiz = -100; // set metodu bu değeri sıfırlayacak.

            Console.WriteLine(a.MaximumHiz); // burada da get metodu tetiklenir ve istersek özelleştirilmiş bir bilgi dönebiliriz.


        }
    }
}
