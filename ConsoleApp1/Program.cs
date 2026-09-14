using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canon c = new Canon(4);
            Nikkon n = new Nikkon(2);
            SmartPhone sp = new SmartPhone();           
            Kalem k = new Kalem();
            Fotografci f = new Fotografci(k);

            sp.VideoPlay();

            f.TakeFoto();
            f.TakeFoto();
            f.TakeFoto();
            sp.Mp3Play();
            f.TakeFoto();
            f.TakeFoto();
            f.TakeFoto();
        }
    }
}
