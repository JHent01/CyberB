
using DZ_5_3;
Console.OutputEncoding = System.Text.Encoding.Unicode;

Store store = new Store(3);

// Додавання деяких товарів у магазин
store[0] = new Article("Молоко", "АТБ", 25.99);
store[1] = new Article("Хліб", "Сільпо", 10.50);
store[2] = new Article("Яблука", "Фора", 20.00);

// Виведення інформації про товар за номером за допомогою індексу
Console.WriteLine("Інформація про товар за номером 1:");
store.DisplayArticleInfo(1);

// Виведення інформації про товар за назвою, введеною з клавіатури
Console.Write("\nВведіть назву товару: ");
string productName = Console.ReadLine();
store.DisplayArticleInfo(productName);
Console.ReadKey();