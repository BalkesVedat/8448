using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBicimlilik1
{
    public class Canli
    {
        public string CanliAd { get; set; }
        public string Tur { get; set; }
        public int OrtalamaOmur { get; set; }
        public string BeslenmeSekli { get; set; }

        public virtual void Beslen()
        {
            Console.WriteLine("Canlı Beslendi");
        }

        public virtual void SesCikar()
        {
            Console.WriteLine("Canli Ses Cikardı");
        }

    }
}
