using System;

namespace Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //program küsib kasutaja nime
            //progmram teenindab kasutajat nimi
            Console.WriteLine("What's your name?");

            string UserName = Console.ReadLine();

            //Console.WriteLine("Hello, " + UserName);
            Console.WriteLine($"Hello, {UserName}");


            Console.Read(); }
    }
}
