using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1_3
{
    internal class Point
    {

        int x;
        int y;
        string name;

        public int X { get; }
        public int Y { get; }
        public string Name { get; }

        

        public Point(int x, int y, string name = "None") 
        {
            X = x;
            Y = y;
            this.name = name;

        }
    }
}