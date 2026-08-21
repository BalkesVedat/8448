using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal abstract class Tasit // abs. bir üye içerdiği için class' ı da abs. yaptık. Fakat tüm üyeleri abs. olmak zorunda değil.
    {
        public int SilindirSayisi { get; set; }
        public int MotorHacmi { get; set; }
        public string YakitTipi { get; set; }

        public abstract void KornaCal(); // abs. olarak işaretledik. Bu nedenle metod gövdesi yok ve alt sınıflarda override edilerek (ezilerek) yazılması gerekiyor. Bu metod soyut olarak işaretlenince bu class'ı da abs. olarak işaretlememiz gerekiyor. Çünki abs. metodlar sadece abs. classların içerisinde olabilir. 

        public void YakitAl(int miktar) // Bu metod abs. değil. alt sınıflarda ezilerek yeniden yazılması gerekmiyor. İstenirse aynen kullanılabilir ya da virtual olarak işaretlenip ezilebilir hale de getirilebilir.
        {
            Console.WriteLine($"{miktar} litre yakıt yüklendi.");
        }
    }
}
