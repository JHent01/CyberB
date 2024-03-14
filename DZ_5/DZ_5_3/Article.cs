using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_3
{
    internal class Article
    {
        private string productName;
        private string storeName;
        private double price;

        
        public Article(string productName, string storeName, double price)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.price = price;
        }

      
        public void DisplayInfo()
        {
            Console.WriteLine("Назва товару: " + productName);
            Console.WriteLine("Магазин: " + storeName);
            Console.WriteLine("Вартість: " + price + " грн");
        }

        
        public string ProductName
        {
            get { return productName; }
        }

        public string StoreName
        {
            get { return storeName; }
        }

        public double Price
        {
            get { return price; }
        }
    }
}
