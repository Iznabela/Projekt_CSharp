using System;

namespace Projekt_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Write some math operation to translate (OBS : Avoid Digits! Just Text Please! ");
            string firstinput = Console.ReadLine();
            string[] words = firstinput.Split(' ');





            foreach (var word in words)
            {
                double number = ConvertStringToDigit(word);
                Console.WriteLine(number);


            }




        }
        static double ConvertStringToDigit(string i)
        {
            switch (i)
            {
                case "Zero": return 0;
                case "One": return 1;
                default: return 10;


            }

        }
    }
}
