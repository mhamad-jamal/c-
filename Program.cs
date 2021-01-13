using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
       Console.WriteLine("\n how old are you ? ");
var input = Console.ReadLine();
var age = Int32.Parse(input);
var dateAndTime = DateTime.Now;
var date = dateAndTime.Year;
var born =  date - age;

Console.WriteLine($"\n you are born on {born }");
Console.Write("\nPress any key to exit...");
Console.ReadKey(true);
        }
    }
}
