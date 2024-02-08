using DZ3_1;
using static DZ3_1.Pupil;

namespace DZ3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pupil pupil1 = new ExcellentPupil();
            Pupil pupil2 = new GoodPupil();
            Pupil pupil3 = new BadPupil();
            Pupil pupil4 = new ExcellentPupil();
         
            ClassRoom classroom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);

            classroom.ShowInfo();

            Console.ReadKey();
        }
    }
}

