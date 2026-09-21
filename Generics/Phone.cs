using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Phone : IMusicPlayer
    {
        public  void play()
        {
            Console.WriteLine("Telefon ile Müzik Çalınıyor");
        }

        public  void stop()
        {
            Console.WriteLine("Telefonda Müzik Durduruldu");
        }
    }
}
