using System;

namespace Projekt_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a math operation to translate (OBS : Avoid Digits! Just Text Please! ");
            string firstinput = Console.ReadLine();

            // parsing the user input
            Conversion.Parse(firstinput);

        }       
    }
}
