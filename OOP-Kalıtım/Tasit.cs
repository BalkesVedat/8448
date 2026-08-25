using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Kalıtım
{
    internal class Tasit
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int UretimYili { get; set; }
        public int MotorHacmi { get; set; }

        public bool UcabilirMi { get; set; }
        public bool YuzebilirMi { get; set; }

        private int maximumHiz;

        public int MaximumHiz
        {
            get { return maximumHiz; }

            set {
                if (value < 0)
                    maximumHiz = 0;
                else
                    maximumHiz = value;
            }
        }



        public void BilgiVer()
        {
            Console.WriteLine($"Marka:\"{Marka}\" \r\nModel:\"{Model}\" \r\nÜretim Yılı:\"{UretimYili}\" \r\nMaximum Hız:\"{MaximumHiz}\"");
        }
    }
}
