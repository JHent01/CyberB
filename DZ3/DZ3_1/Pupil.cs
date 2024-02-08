using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_1
{
     class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil is studying");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil is reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil is writing");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil is relaxing");
        }

       public class ExcellentPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine(" Pupil excellent studying");
            }

            public override void Read()
            {
                Console.WriteLine(" Pupil excellent reading");
            }

            public override void Write()
            {
                Console.WriteLine(" Pupil excellent writing");
            }

            public override void Relax()
            {
                Console.WriteLine(" Pupil excellent relaxing");
            }
        }

        public class GoodPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine(" Pupil good studying");
            }

            public override void Read()
            {
                Console.WriteLine(" Pupil good  reading");
            }

            public override void Write()
            {
                Console.WriteLine(" Pupil good  writing");
            }

            public override void Relax()
            {
                Console.WriteLine(" Pupil good  relaxing");
            }
        }

        public class BadPupil : Pupil
        {
            public override void Study()
            {
                Console.WriteLine(" Pupil bad studying");
            }

            public override void Read()
            {
                Console.WriteLine(" Pupil bad is reading");
            }

            public override void Write()
            {
                Console.WriteLine(" Pupil bad is writing");
            }

            public override void Relax()
            {
                Console.WriteLine(" Pupil bad is relaxing");
            }
        }

            


    }
}
