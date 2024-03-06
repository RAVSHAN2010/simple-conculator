# simple-conculator
it's about cod calculator. With this code, you can easily work with examples. It uses if and else if. If you use this code, you solve one example, if you want to continue, yes, if you want to stop, it says load, if you say yes, it will work again, if you say load, the code will stop !!!

# Appearance of cod
![Home page](/image/photo_2024-03-05_21-53-03.jpg)


# DOTNET RUN
![home page](/image/running.gif)


# CODE 
```csharp
using System.Globalization;

Hi:
Console.Write("birinchi soni kriting = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("ikkinchi soni kriting = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" + ; - ; * ; / ");
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
Console.WriteLine("agar davom ettirmoqchi bulsangiz ha tuxtatmoqchi bulasangiz yuq");
string d = Convert.ToString(Console.ReadLine());
if (d == "ha")
{
   goto Hi; 
}
else if(d =="yuq "){
    System.Console.WriteLine("hayr");
}
```