using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil ferrari = new Otomobil();
            ferrari.Marka = "Ferrari";
            ferrari.Model = "F1";

           ferrari.Calistir();
           ferrari.Yavasla();

            if (ferrari.YakitVarMi())
            { 
                
            }

        }
    }
}
