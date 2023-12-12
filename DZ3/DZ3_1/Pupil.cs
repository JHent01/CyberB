using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_1
{
    internal class Pupil
    {
        //public string study = "No info";
        //public string read = "No info";
        //public string write = "No info";
        //public string relax = "No info";
        virtual public void Study()
        {
            
        }
        virtual public void Read() 
        {
             
        }
        virtual public void Write()
        {
             
        }
        virtual public void Relax()
        {
           
        }
    }
    internal class ExcelentPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Excelent Pupil Study");
        }
        public override void Read()
        {
            Console.WriteLine("Excelent Pupil Read");
        }
        public override void Write()
        {
            Console.WriteLine("Excelent Pupil Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Excelent Pupil Relax");
        }
    }
    internal class GoodPupil: Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Good Pupil Study");
        }
        public override void Read()
        {
            Console.WriteLine("Good Pupil Read");
        }
        public override void Write()
        {
            Console.WriteLine("Good Pupil Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Good Pupil Relax");
        }
    }
    internal class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Bad Pupil Study");
        }
        public override void Read(      )
        {
            Console.WriteLine("Bad Pupil Read");
        }
        public override void Write()
        {
            Console.WriteLine("Bad Pupil Write");
        }
        public override void Relax()
        {
            Console.WriteLine("Bad Pupil Relax");
        }
    }
}
