using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3_4
{
    internal class BasicWorker : DocumentWorker
    {
        public override string OpenDocument(string open)
        {
            Console.WriteLine(base.openDocument);
            return "";
        }
        public override string EditDocument(string edit)
        {
            Console.WriteLine(base.editDocument);
            return "";
        }



        public override string SaveDocument(string save)
        {
            Console.WriteLine(base.saveDocument);
            return "";
        }
    }
}
