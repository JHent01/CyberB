using DZ_5_2;
Console.OutputEncoding = System.Text.Encoding.Unicode;

MyMatrix matrix = new MyMatrix(4, 4);


for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix.SetElement(i, j, i * 4 + j + 1); 
    }
}


Console.WriteLine(" Початкова матриця:");
matrix.PrintMatrix();


Console.WriteLine("\n Похідні матриці:");


Console.WriteLine("\n Матриця порядку 2:");
MyMatrix derMatrix2 = new MyMatrix(2, 2);
for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        derMatrix2.SetElement(i, j, matrix.GetElement(i, j));
    }
}
derMatrix2.PrintMatrix();


Console.WriteLine("\n Матриця порядку 1:");
MyMatrix derMatrix1 = new MyMatrix(1, 1);
derMatrix1.SetElement(0, 0, matrix.GetElement(0, 0));
derMatrix1.PrintMatrix();