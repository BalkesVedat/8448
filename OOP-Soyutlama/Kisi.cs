using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Soyutlama
{
    internal abstract class Kisi // abstract olarak işaretledik çünki içerisinde abstract bir metodu mevcut. 
    {
        public int KisiID { get; set; }
        public string AdSoyad { get; set; }
        public string EMail { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        public void KisiSil(int id) // Alt sınıflardan aynen çağırılarak kullanılacak.
        {
            Console.WriteLine("Kişi silindi");
        }

        public virtual void BilgiVer() // Alt sınıflarda istenirse ezilerek (override), istenirse ezilmeden buradaki kod çağrılarak kullanılabilir. 
        {
            Console.WriteLine($"Ad Soyad:{AdSoyad} Email:{EMail} ID:{KisiID}");
        }

        public abstract void KisiKaydet();  // Alt sınıflarda ezilecek
    }
}
