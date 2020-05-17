using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    static class Sound
    {
        public static void MakeSound(string soundName)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer($@"..\..\Sounds\{soundName}.wav");
            sound.Play();
        }
    }
}
