using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Kalem : IFotoMachine
    {
        public void TakePhoto()
        {
            Console.WriteLine("Casus Kalem ile Fotoğraf çekiliyor");
        }
    }
}
