using System;
using System.Net.Http;

namespace Projekt_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion conversion = new Conversion();

            Console.WriteLine("Write a math operation to translate (OBS : Avoid Digits! Just Text Please! ");
            string firstinput = Console.ReadLine();

            // parsing the user input
            try
            {
                conversion.Parse(firstinput);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw new Exception("ERROR", e);
            }           
        }       
    }
}
