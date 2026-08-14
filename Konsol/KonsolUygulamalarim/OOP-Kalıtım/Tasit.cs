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


        public void BilgiVer()
        {
            Console.WriteLine($"Marka:\"{Marka}\" \r\nModel:\"{Model}\" \r\nÜretim Yılı:\"{UretimYili}\" \r\n");
        }
    }
}
