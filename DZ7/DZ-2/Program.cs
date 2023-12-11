
using DZ_2;

static void ClassTaker(MyClass myClass)
{
    myClass.change = "змінено";

}

static void StruktTaker(MyStruct myStruct)
{
    myStruct.change = "змінено";
}

MyClass myClass = new MyClass();
MyStruct myStruct = new MyStruct();
myStruct.change = "не змінено";
myClass.change = "не змінено";
Console.WriteLine(myClass.change);
Console.WriteLine(myStruct.change);
ClassTaker(myClass);
StruktTaker(myStruct);
Console.WriteLine(myClass.change);
Console.WriteLine(myStruct.change);
myStruct.change = "змінено";
Console.WriteLine(myStruct.change);