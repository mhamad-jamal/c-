using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
       Console.WriteLine("\nWhat is your born Year ? ");
var input = Console.ReadLine();
var born = Int32.Parse(input);
var dateAndTime = DateTime.Now;
var date = dateAndTime.Year;
var age =  date - born;

Console.WriteLine($"\nyou are  {age}  year old");
Console.Write("\nPress any key to exit...");
Console.ReadKey(true);
        }
    }
}
