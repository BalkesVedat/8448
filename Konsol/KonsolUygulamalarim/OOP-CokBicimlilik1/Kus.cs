using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBicimlilik1
{
    public class Kus : Canli
    {
        public int YumurtaRengi { get; set; }
        public void SesCikar()
        {
            Console.WriteLine("Cik Cik");
        }

        public override void Beslen()
        {
            Console.WriteLine("Kuş Beslendi");
        }
    }
}
