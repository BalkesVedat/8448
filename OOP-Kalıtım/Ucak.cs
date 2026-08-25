using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    internal class Ucak : Tasit
    {
        public Ucak()
        {
            UcabilirMi = true;
        }

        public int YolcuSayisi { get; set; }
        public int YukKapasitesi { get; set; }
    }
}
