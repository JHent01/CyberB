using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_2
{
    internal class Player : IPlayable, IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Playing...");
        }

        public void Pause()
        {
            Console.WriteLine("Pausing...");
        }

        public void Stop()
        {
            Console.WriteLine("Stopping...");
        }

        public void Record()
        {
            Console.WriteLine("Recording...");
        }
    }
}
