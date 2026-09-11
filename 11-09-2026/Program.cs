using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11_09_2026
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //double deger=rnd.NextDouble();
            //Console.WriteLine((int)(deger*100));
            //int deger2=rnd.Next();
            //Console.WriteLine(deger2);
            //int deger3=rnd.Next(1,6);
            //Console.WriteLine(deger3);

            // 6/49 Sayısal Loto
            // 1-49 arasında bir rakam dizis seçiiyor
            // çekiliş ile 1-49 arasında bir rakam dizisi belirlenip 
            // iki dizi arasında kaç tane doğru bilgiğine göre ikramiye

            int[] tahmin = kullanicidanSayilariAl();
            Console.WriteLine("Kullanıcıdan tahminler alındı, Makine sayıları çekiyor");
            int[] sayilar = makinaSayilariCeksin();
            int dogruSayisi = dizileriKontrolEt(tahmin, sayilar);
            Array.Sort(tahmin);
            Array.Sort(sayilar);
            Console.WriteLine($"Senin Tahminlerin: {string.Join(", ", tahmin)}");
            Console.WriteLine($"Makinanın Sayıları: {string.Join(", ", sayilar)}");
            Console.WriteLine($"Doğru Sayısı: {dogruSayisi}");
        }

        private static int[] makinaSayilariCeksin()
        {
            Random rnd = new Random();
            int[] sayilar = new int[6];
            int count = 0;
            while (count < 6)
            {
                int giris = rnd.Next(1, 50);
                Console.WriteLine($"Sayı: {giris}");
                if (isMukerrer(ref sayilar, giris))
                {
                    sayilar[count] = giris;
                    Console.WriteLine($"{giris} sayısı {count + 1} eleman olarak eklendi...");
                    count++;
                }
            }
            return sayilar;
        }

        private static int[] kullanicidanSayilariAl()
        {
            int[] tahmin = new int[6];
            int count = 0;
            while (count < 6)
            {
                int giris = -1;
                Console.WriteLine("Bir Sayı Giriniz");
                int.TryParse(Console.ReadLine(), out giris);
                if (!veriDogru(giris))
                {
                    continue;
                }
                if (isMukerrer(ref tahmin, giris))
                {
                    tahmin[count] = giris;
                    Console.WriteLine($"{giris} sayısı {count + 1} eleman olarak eklendi...");
                    count++;
                }
                else
                {
                    Console.WriteLine($"{giris} sayısı daha önceden eklendi...");
                }
            }
            return tahmin;
        }

        private static int dizileriKontrolEt(int[] tahmin, int[] sayilar)
        {
            int dogruSayisi = 0;
            for (int i = 0; i < tahmin.Length; i++)
            {
                for (int j = 0; j < sayilar.Length; j++)
                {
                    if (tahmin[i] == sayilar[j])
                    {
                        dogruSayisi++;
                    }
                }
            }
            return dogruSayisi;
        }

        private static bool veriDogru(int giris)
        {
            Console.WriteLine($"Kontrol edilecek Sayı: {giris}");
            return giris > 0 && giris < 50;
        }

        private static bool isMukerrer(ref int[] tahmin, int giris)
        {
            for (int i = 0; i < tahmin.Length; i++)
            {
                if (tahmin[i] == giris)
                {
                    Console.WriteLine("Sayı istenen kriteri sağlamıyor");
                    return false;
                }
            }
            return true;
        }
    }
}
