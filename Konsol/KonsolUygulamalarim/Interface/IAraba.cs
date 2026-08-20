using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IAraba
    {
        string Marka { get; set; }
        string Model { get; set; }
        int MaximumHiz { get; set; }

        void Calistir();
        bool YakitVarMi();

        void Yavasla();
    }
}
