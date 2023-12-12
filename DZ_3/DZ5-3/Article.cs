using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ5_3
{
    internal class Article
    {
        string name;
        string nameShop;
        double price;
        public Article(string name,string nameShop,double price)
        { 
            this.name = name;
            this.nameShop = nameShop;
            this.price = price;
        }

    }
}
