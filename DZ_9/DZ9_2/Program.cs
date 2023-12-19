using System;


class Program
{
    delegate int Number();
    delegate double MyDel(Number[] a);

    

    static void Main(string[] args)
    {
        Random random = new Random();
         int GetRandom()
         {

            int number = random.Next(10);
            Console.WriteLine(number);
            return number;
         }
       
        

        Console.WriteLine("Введіть кількість елементів масива: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 50));

        var array = new Number[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = () => new Number(GetRandom)();
        }

        MyDel ser = delegate (Number[] num)
        {
            double sr = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sr += num[i]();
            }
            return sr / array.Length;
        };

        Console.WriteLine($"Среднее ариф = {ser(array)}");
       

        
    }
}