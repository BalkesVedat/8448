using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Kamyon : Tasit, IAraba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaximumHiz { get; set; }

        public void Calistir()
        {
            
        }

        public override void KornaCal()
        {
            Console.WriteLine("Kamyon Korna Çaldı");
        }

        public bool YakitVarMi()
        {
            return true;
        }

        public void Yavasla()
        {
           
        }
    }
}
