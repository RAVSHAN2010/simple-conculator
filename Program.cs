// See https://aka.ms/new-console-template for more informationC
using System.Globalization;

Hi:
Console.Write("birinchi soni kriting = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ikkinchi soni kriting = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" + , -, *, /");
string c = Convert.ToString(Console.ReadLine());
if(c == "+")
{
    Console.WriteLine(a + b);
}
if(c == "-")
{
    Console.WriteLine(a - b);
}
if(c == "*")
{
    Console.WriteLine(a * b);
}
if(c == "/")
{
    Console.WriteLine(a / b);
}
Console.WriteLine("Do you want to continue? yes or no");
string d = Convert.ToString(Console.ReadLine());
if (d == "ha")
{
    goto Hi;
}
else if(d == "yuq")
{
    Console.WriteLine("ok");
}