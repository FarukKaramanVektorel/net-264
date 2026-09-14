using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class FotografMakinasi:IFotoMachine
    {
        public double Bellek { get; set; }
        public FotografMakinasi(double bellek)
        {
            Bellek = bellek;
        }

        public abstract void TakePhoto();
    }
}
