using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_1
{
    internal class DOCHandler: AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Document DOC Open");
        }
        public override void Change()
        {
            Console.WriteLine("Document DOC Change");
        }
        public override void Create()
        {
            Console.WriteLine("Document DOC Create");
        }

        public override void Save()
        {
            Console.WriteLine("Document DOC Save");
        }
    }
}
