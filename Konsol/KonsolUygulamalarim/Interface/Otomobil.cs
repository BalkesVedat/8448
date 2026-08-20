using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Otomobil :Tasit,IAraba,IUcabilir
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaximumHiz { get; set; }

        public bool Ucabilir { get; set; }

        public void Calistir()
        {
            Console.WriteLine("Otomobil Çalıştı");
        }

        public override void KornaCal()
        {
            Console.WriteLine("Otomobil ses çıkardı.");
        }

        public bool YakitVarMi()
        {
            return true;
        }

        public void Yavasla()
        {
            Console.WriteLine("Araba Yavaşla");
        }
    }
}
