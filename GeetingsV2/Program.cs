using System;

namespace GeetingsV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib kasutaja eesnimi
            //program küsib kasturaja perekonnanime
            //program tervitab kasutajat, kasutated neid andmeid
            
            Console.WriteLine("Hello World!");

            Console.WriteLine("What's your name?");

            string UserName = Console.ReadLine();

            Console.WriteLine("What's your name Surname?");

            string SurnName = Console.ReadLine();

            Console.WriteLine($"Hello, {UserName} {SurnName}");

            Console.Read();
        }
    }
}
