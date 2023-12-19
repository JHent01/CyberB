  int Parse(string a)
{
    bool tryParse;
    int parse;
    tryParse = int.TryParse(a, out parse);
    if (tryParse == true)
    {
        parse = int.Parse(a);
        return parse;
    }
    else Console.WriteLine("Введено не число");
    return 0;
}
int a,b,c;
string pars;
Console.WriteLine("Введіть число 1");
pars=Console.ReadLine();
a = Parse(pars);
Console.WriteLine("Введіть число 2");
pars = Console.ReadLine();
b = Parse(pars);
c = 0;

Func<int,int> Add = c=> a+b;
Console.WriteLine(Add(c));
Func<int,int> Sub = c=> a-b;
Console.WriteLine(Sub(c));
Func<int,int> Mul = c=> a*b;
Console.WriteLine(Mul(c));
try
{
    Func<int, int> Div = c => a / b;
    Console.WriteLine(Div(c));
}
catch (Exception ex)
{ Console.WriteLine(ex.Message); }


