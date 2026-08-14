using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    internal class Helikopter:Tasit
    {
        public Helikopter()
        {
            UcabilirMi = true;
        }
        public int KanatSayisi { get; set; }
    }
}
