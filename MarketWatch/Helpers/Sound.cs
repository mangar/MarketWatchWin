using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Helpers
{
    public class Sound
    {

        async public static void PlayOpen() 
        {
            using (var mp3FileReader = new Mp3FileReader(@"Resources/open.mp3"))
            using (var waveOut = new WaveOutEvent())
            {
                waveOut.Init(mp3FileReader);
                waveOut.Play();
                Console.WriteLine("Playing...");
                while (waveOut.PlaybackState == PlaybackState.Playing)
                {
                    System.Threading.Thread.Sleep(100);
                }
                Console.WriteLine("Playback Stopped.");
            }
        }
    }
}
