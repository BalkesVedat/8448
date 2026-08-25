using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CokBicimlilik1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kus ordek = new Kus();

            Canli kugu = new Kus();

            Inek i = new Inek();

            object liste = new List<Kus>();

            object isimler = new String[5];

            Zurafa z = new Zurafa();

            ((Kus)kugu).YumurtaRengi = 125;

            kugu.SesCikar();
            ordek.SesCikar();
            i.SesCikar();
            z.SesCikar();

        }
    }
}
