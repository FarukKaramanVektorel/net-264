using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace horse_racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Horse h1 = new Horse("Karayel", 4, 72);
            Horse h2 = new Horse("Karayel1", 4, 75);
            Horse h3 = new Horse("Karayel2", 4, 90);
            Horse h4 = new Horse("Karayel3", 4, 92);
            Horse h5 = new Horse("Karayel4", 4, 78);
            Horse h6 = new Horse("Karayel5", 4, 76);
            Horse h7 = new Horse("Karayel6", 4, 87);
            Hipodrom hpd = new Hipodrom(100,new Horse[] { h1, h2, h3, h4, h5, h6, h7 },"Veli Efendi");
            hpd.start();
        }
    }
}
