using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SmartPhone : Phone, IFotoMachine,IVideoPlayer, IMp3Player
    {
        public void Mp3Play()
        {
            Console.WriteLine("Mp3 Oynatılıyor");
        }

        

        public void TakePhoto()
        {
            Console.WriteLine("Cep Telefonu ile fotoğraf çekildi");
        }

        public void VideoPlay()
        {
            Console.WriteLine("Video Oynatılıyor");
        }
    }
}
