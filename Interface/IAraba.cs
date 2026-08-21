using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAraba
    {
        //Constructor içermez.
        string Marka { get; set; } // Interface içerisinde yazılan üyelere erişim belirleyici yazılmaz. (public, private v.b.)
        string Model { get; set; }
        int MaximumHiz { get; set; }

        void Calistir(); // metodların gövdeleri olmaz. Gövde kodları bu interface i uygulayan sınıfta yazılır.
        bool YakitVarMi();

        void Yavasla();
    }
}
