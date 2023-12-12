


using DZ5_3;

Store shop = new Store();
Article prod = new Article("qq","shop",11);
Article prod2 = new Article("q2q", "shop", 121);
Article prod3 = new Article("q3q", "shop", 131);
shop.articles.ToList().Add(prod);
shop.articles.ToList().Add(prod2);
shop.articles.ToList().Add(prod3);

Console.WriteLine(shop);
Console.WriteLine(shop.articles);

foreach (var item in shop.articles)
{ 
    Console.WriteLine(item);
}