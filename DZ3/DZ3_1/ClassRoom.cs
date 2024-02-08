using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_1
{
     class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3, pupil4 };
        }

        public ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            pupils = new Pupil[] { pupil1, pupil2, pupil3 };
        }

        public void ShowInfo()
        {
            Console.WriteLine("Classroom info:");
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"Pupil {i + 1}:");             
                pupils[i].Study();              
                pupils[i].Read();               
                pupils[i].Write();               
                pupils[i].Relax();               
            }
        }
    }
}
