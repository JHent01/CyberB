using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_1
{
    internal class ClassRoom
    {
        Pupil[] pupil;

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            pupil = new Pupil[] { p1, p2, p3, p4 };
        }
        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            pupil = new Pupil[] { p1, p2, p3 };
        }
        public ClassRoom(Pupil p1, Pupil p2)
        {
            pupil = new Pupil[] { p1, p2 };
        }

        public void PrintInfoStudy()
        {
            Console.WriteLine("Study: ");
            foreach (Pupil item in pupil)
                item.Study();
        }
        public void PrintInfoRead()
        {
            Console.WriteLine("Read: ");
            foreach (Pupil item in pupil)
                item.Read();
        }
        public void PrintInfoWrite()
        {
            Console.WriteLine("Write: ");
            foreach (Pupil item in pupil)
                item.Write();
        }
        public void PrintInfoRelax()
        {
            Console.WriteLine("Relax: ");
            foreach (Pupil item in pupil)
                item.Relax();
        }
    }
}
