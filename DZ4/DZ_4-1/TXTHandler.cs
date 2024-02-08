using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_1
{
    internal class TXTHandler: AbstractHandler
    {
       
        public override void Open()
        {
            Console.WriteLine("Document TXT Open");
        }
        public override void Change()
        {
            Console.WriteLine("Document TXT Change");
        }
        public override void Create()
        {
            Console.WriteLine("Document TXT Create");
        }

        public override void Save()
        {
            Console.WriteLine("Document TXT Save");
        }
    }
}
