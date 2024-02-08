using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_1
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();

    }
}
