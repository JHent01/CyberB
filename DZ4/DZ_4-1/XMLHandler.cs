using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_1
{
    internal class XMLHandler : AbstractHandler 
    {
       



        public override void Open()
        {
            Console.WriteLine("Document XML Open");
        }
        public override void Change()
        {
            Console.WriteLine("Document XML Change");
            
        }
        public override void Create()
        {
            Console.WriteLine("Document XML Create");
             
        }

        public override void Save()
        {
            Console.WriteLine("Document XML Save");
        }

    }
}
