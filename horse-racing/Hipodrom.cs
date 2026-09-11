using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace horse_racing
{
    internal class Hipodrom
    {
        public int Mesafe { get; set; }
        public Horse[] Horses { get; set; }

        public string Name { get; set; }

        public Hipodrom(int mesafe, Horse[] horses, string name)
        {
            Mesafe = mesafe;
            Horses = horses;
            Name = name;
        }


        public void start()
        {
            Console.WriteLine($"Selamlar sevgili At severler {Name} Hipodromundan ben spikeriniz Akif");
            Console.WriteLine("Yarışacak Atları söylüyorum...");
            horsesList(Horses);
            Console.WriteLine($"Pist mesafesi: {Mesafe} dir.");
            Console.WriteLine("Yarış Başlıyor...");
            basla();
        }

        private void basla()
        {
            int[] gidilenMEsafeler = new int[Horses.Length];
            int index = -1;
            int ayak = 1;
            bool isRunning = true;
            while (isRunning) {
                Console.WriteLine($"====={ayak}. AYAK BAŞLADI=====");
                for (int i = 0; i < gidilenMEsafeler.Length; i++)
                {
                    Thread.Sleep(50);
                    
                    gidilenMEsafeler[i] += Horses[i].ilerle();
                    if(isWinner(gidilenMEsafeler, out index))
                    {
                        isRunning = false;
                        break;
                    }
                    string tire = "-";
                    for (int j = 0; j < gidilenMEsafeler[i]; j++)
                    {
                        tire += "-";
                        
                    }
                    Console.WriteLine(tire+">"+Horses[i].Name);

                }
                ayak++;
                Console.Clear();
            }
            Console.WriteLine($"Kazanan At: {Horses[index].info()}");
        }

        private bool isWinner(int[] gidilenMEsafeler, out int index)
        {
            bool win = false;
            index = -1;
            for (int i = 0; i < gidilenMEsafeler.Length; i++)
            {                
                if (gidilenMEsafeler[i] >= Mesafe)
                {
                    win = true;
                    index = i;
                    break;
                }                
            }
            return win;
        }

        private void horsesList(Horse[] horses)
        {
            foreach (Horse horse in horses)
            {
                Console.WriteLine(horse.info()); 
            }
        }
    }
}
