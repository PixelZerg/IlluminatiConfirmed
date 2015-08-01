using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    class Drama
    {
        private static System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Resources\Music\Drama.wav");
        public static void Play()
        {
            player.Play();
        }
        public static void Stop()
        {
            player.Stop();
          //  player.Dispose();
        }
    }

    class Illuminati
    {
        private static System.Media.SoundPlayer playier = new System.Media.SoundPlayer(@"Resources\Music\moosic.wav");
        public static void Play()
        {
            playier.Play();
        }
        public static void Stop()
        {
            playier.Stop();
            Console.ReadKey();
        }
    }
}
