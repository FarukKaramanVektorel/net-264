using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Canon : FotografMakinasi // is a
    {
        public Canon(double bellek) : base(bellek)
        {
        }

        public override void TakePhoto()
        {
            if (Bellek > 0)
            {
                Console.WriteLine("Canon ile Fotoğraf Çekildi");
                Bellek--;
            }
            else
            {
                Console.WriteLine("Canonun Bellek doldu");
            }
        }
    }
}
