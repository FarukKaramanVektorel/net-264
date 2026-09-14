using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nikkon : FotografMakinasi
    {
        public Nikkon(int bellek) : base(bellek)
        {
        }

        public override void TakePhoto()
        {
            if (Bellek > 0.5)
            {
                Console.WriteLine("Nikkon ile Fotoğraf Çekildi, Kalan Bellek: "+Bellek);
                Bellek -= 0.5;
            }
            else
            {
                Console.WriteLine("Nikkonun Bellek Dolu");
            }
        }
    }
}
