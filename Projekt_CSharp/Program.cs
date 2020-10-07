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
                char operate = ConvertStringToChar(word);
                Console.WriteLine($"{number + operate} ");

            }
        }




        static double ConvertStringToDigit(string word)
        {

            switch (word)
            {
                case "zero": return 0;
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
                case "four": return 4;
                case "five": return 5;
                case "six": return 6;
                case "seven": return 7;
                case "eight": return 8;
                case "nine": return 9;
                case "ten": return 10;
                default: return 0;




            }

        }
        static char ConvertStringToChar(string operat)
        {
            switch (operat)
            {
                case "plus": return '+';
                case "minus": return '-';
                case "multipy by": return '*';
                case "divided by": return '/';
                default:
                    return '#';




            }

        }
    }
}
