struct Notebook
{
    string model;
    string producer;
    int price;
    public Notebook(string model, string producer, int price)
    {
        this.model = model;
        this.producer = producer;
        this.price = price;
    }
    public void Print()
    {
        Console.WriteLine($"Модель: {model} Виробник: {producer} Ціна: {price}");
   

    }
}



class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Введіть модель та виробника: ");
        Notebook notebook = new Notebook(Console.ReadLine(), Console.ReadLine(),22);
        notebook.Print();
        Console.ReadLine();
    }
}
