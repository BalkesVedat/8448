using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Otobus : Tasit,IAraba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaximumHiz { get; set; }

        public void Calistir()
        {
            Console.WriteLine("Otobüs çalıştı"); 
        }

        public bool YakitVarMi()
        {
            return true;
        }

        public void Yavasla()
        {
            Console.WriteLine("Otobüs yavaşladı.");
        }

        public override void KornaCal()
        {
            Console.WriteLine("Otobüs korna çaldı.");
        }
    }
}
