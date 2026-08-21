using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Soyutlama
{
    internal class Ogretmen : Kisi
    {
        public override void KisiKaydet()
        {
            Console.WriteLine("Ogretmen Kaydedildi.");
        }
    }
}
