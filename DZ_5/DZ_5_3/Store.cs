using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_5_3
{
    internal class Store
    {
        private Article[] articles;

        
        public Store(int cap)
        {
            articles = new Article[cap];
        }

        
        public Article this[int index]
        {
            get { return articles[index]; }
            set { articles[index] = value; }
        }

        
        public void DisplayArticleInfo(int index)
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index].DisplayInfo();
            }
            else
            {
                Console.WriteLine("Товар з вказаним номером не знайдено.");
            }
        }
        public void DisplayArticleInfo(string productName)
        {
            bool found = false;
            foreach (Article article in articles)
            {
                if (article != null && article.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase))
                {
                    article.DisplayInfo();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Товар з назвою \"" + productName + "\" не знайдено.");
            }
        }
        }
}
