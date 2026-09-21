using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] arr = { "bişey", 45, 4.89, false };

            foreach (object o in arr)
            {
                if(o is string)
                {

                }
            }
            delegate void Islem(int sayi);


            Islem islem = KareAl;

            islem(5);

        }
        static void KareAl(int sayi)
        {
            Console.WriteLine(sayi * sayi);
        }
    }
}
