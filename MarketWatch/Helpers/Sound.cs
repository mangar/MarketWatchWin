using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketWatch.Helpers
{
    public class Sound
    {

        public static bool Playing = false;

        public static void PlayOpenApp()
        {
            if (!Sound.Playing)
            {
                string filePath = @"Resources/Sounds/openapp.mp3";
                Thread playbackThread = new Thread(() => Sound._Play(filePath));
                playbackThread.Start();
            }
        }

        public static void PlayOpen()
        {
            if (!Sound.Playing)
            {
                string filePath = @"Resources/Sounds/open.mp3";
                Thread playbackThread = new Thread(() => Sound._Play(filePath));
                playbackThread.Start();
            }
        }

        public static void PlayClose()
        {
            if (!Sound.Playing)
            {
                string filePath = @"Resources/Sounds/close.mp3";
                Thread playbackThread = new Thread(() => Sound._Play(filePath));
                playbackThread.Start();
            }
        }

        public static void PlayPreOpen()
        {
            if (!Sound.Playing)
            {
                string filePath = @"Resources/Sounds/preopen.mp3";
                Thread playbackThread = new Thread(() => Sound._Play(filePath));
                playbackThread.Start();
            }
        }

        public static void PlayPreClose()
        {
            if (!Sound.Playing)
            {
                string filePath = @"Resources/Sounds/preclose.mp3";
                Thread playbackThread = new Thread(() => Sound._Play(filePath));
                playbackThread.Start();
            }
        }


        public static void _Play(string filePath) 
        {
            if (ConfigHelper.Config.Features.FlagAlarms)
            {
                IWaveSource soundSource = CodecFactory.Instance.GetCodec(filePath);              
                
                using (var soundOut = new WasapiOut())
                {
                    soundOut.Initialize(soundSource);
                    soundOut.Play();
                    Sound.Playing = true;

                    while (soundOut.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(500); // Check every half-second
                    }
                    Sound.Playing = false;
                }
            }
        }



    }
}
