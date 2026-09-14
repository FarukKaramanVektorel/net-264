using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Fotografci
    {

        // Open/Close Geliştirmeye Açık/Değişime Kapalı

        //Polimorfizm / Çokbiçimlilik
        public IFotoMachine FotografMakinasi { get; set; }

        public Fotografci(IFotoMachine machine) {
            FotografMakinasi = machine;
        }

        public void TakeFoto()
        {
            FotografMakinasi.TakePhoto();
        }
    }
}
