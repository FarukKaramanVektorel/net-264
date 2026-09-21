using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SiparisDurumu durum = SiparisDurumu.IptalEdildi;
            Console.WriteLine(durum);
            Console.WriteLine((int)durum);

            if (durum == SiparisDurumu.IptalEdildi)
            {
                Console.WriteLine("Kargo iade edildi");
            }

            Console.WriteLine((int)Code.GecersizIstek+" "+Code.GecersizIstek);
            Console.WriteLine(Yon.Guney);
            Console.WriteLine((int)Yon.Guney);
            Console.WriteLine((byte)Yon.Guney);

            // enum -> int açık dönüşüm

            int sayi = (int)durum;
            Console.WriteLine(sayi);

            //int -> enum açık dönüşüm
            Yon y = (Yon)4;
            Console.WriteLine(y);

            // string -> enum Enum.Parse
            Yon y2 = (Yon)Enum.Parse(typeof(Yon), "Dogu");

            Console.WriteLine(y2);

            // strng-> enum Enum.TryParse
            bool status= Enum.TryParse( "Doğu",out Yon y3);
            Console.WriteLine(status);
            Console.WriteLine(y3);

            // enum -> string

            string deger = SiparisDurumu.TeslimEdildi.ToString();
            Console.WriteLine(deger);
         
            foreach (var id in Enum.GetValues(typeof(Code))) {
                Console.WriteLine((int)id);
            }

            Console.WriteLine(Enum.IsDefined(typeof(SiparisDurumu), 2)); 
            Console.WriteLine(Enum.IsDefined(typeof(SiparisDurumu), "TeslimEdildi")); 
            SiparisDurumu sd = (SiparisDurumu)45;
            Console.WriteLine(sd);
        }
    }
}
