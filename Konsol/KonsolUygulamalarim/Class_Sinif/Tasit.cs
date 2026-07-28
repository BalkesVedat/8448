using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Sinif
{
    public enum YakitTipi
    {
        Benzin,
        Motorin,
        Elektrik,
        LPG,
        Hibrit
    }



    internal class Tasit
    {
        //Full property tanımı ile Encapsulation
        private string plaka;
        public string _plaka
        {
            get { return plaka; }
            set { plaka = value; }
        }

        private string marka;

        public string _marka
        {
            get { return marka; }
            set { marka = value; }
        }

        public string _model { get; set; }

        private int silindirSayisi;

        public int _silindirSayisi
        {
            get { return silindirSayisi; }
            set
            {
                if (value >= 1 && value <= 48)
                {
                    silindirSayisi = value;
                }
            }
        }

        public YakitTipi _yakitTipi { get; set; }

        private int yakitHacmi;
        public int _yakitHacmi
        {
            get { return yakitHacmi; }
            set
            {
                if (value >= 0 && value <= 500)
                {
                    yakitHacmi = value;
                }
            }
        }

        private string motorSaseNo = "NA";

        public string _motorSaseNo
        {
            get {
                if (motorSaseNo == "NA")
                    return "Değer Atanmamış";
                else
                    return motorSaseNo; 
            }
            set {
                if (motorSaseNo == "NA")
                {
                    motorSaseNo  = value; 
                }
            }
        }

    }
}
