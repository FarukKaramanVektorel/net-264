using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Genco
    {
        public IMusicPlayer Mp { get; set; }

        public Genco(IMusicPlayer mp) {
            Mp = mp;
        }

        public void MusicDinle()
        {
            Mp.play();
        }
    }
}
