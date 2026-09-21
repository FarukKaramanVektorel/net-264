using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MusicPlayer : IMusicPlayer
    {
        public virtual void play()
        {
            Console.WriteLine("Müzik Çalınıyor");
        }

        public virtual void stop()
        {
            Console.WriteLine("Müzik Durduruldu");
        }
    }
}
