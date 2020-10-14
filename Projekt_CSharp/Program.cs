using System;
using System.Net.Http;

namespace Projekt_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion conversion = new Conversion();

            Console.WriteLine("Write a math operation with up to 3 operators and 5 values - between one and ten!");
            Console.WriteLine("(OBS : Avoid Digits! Only Text Please!");
            Console.WriteLine();
            string userInput = Console.ReadLine();

            try
            {
                conversion.Parse(userInput);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException();
            }           
        }       
    }
}
