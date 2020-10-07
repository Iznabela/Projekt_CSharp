using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_CSharp
{
    public static class Conversion
    {
        public static double Parse(string userInput)
        {
            double result = 0;

            string[] words = userInput.Split(' ');

            // TEMPORARY
            // list and char to save the converted values and operators in (we will change this later to value and operator Objects)
            List<double> values = new List<double> { };
            char op = '?';

            foreach (var word in words)
            {
                if (isDigit(word))
                {
                    values.Add(ConvertStringToDigit(word));
                }
                else if (isOperator(word))
                {
                    op = ConvertStringToChar(word);
                }
            }

            // checking what operator user entered
            switch (op)
            {
                case '+':
                    result = values[0] + values[1];
                    break;
                case '-':
                    result = values[0] - values[1];
                    break;
                case '*':
                    result = values[0] * values[1];
                    break;
                case '/':
                    result = values[0] / values[1];
                    break;
            }
            
            // printing the calculation and the result
            Console.Write($"{values[0]} {op} {values[1]} = {result}");

            return result;
        }

        // checking if a word is digit
        public static bool isDigit(string word)
        {
            switch (word)
            {
                case "zero":
                case "one":
                case "two":
                case "three":
                case "four":
                case "five":
                case "six":
                case "seven":
                case "eight":
                case "nine":
                case "ten":
                    return true;
                default:
                    return false;
            }
        }

        // checking if a word is operator
        public static bool isOperator(string word)
        {
            switch (word)
            {
                case "plus":
                case "minus":
                case "times":
                case "divided":
                    return true;
                default:
                    return false;
            }
        }

        public static double ConvertStringToDigit(string word)
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

        public static char ConvertStringToChar(string operat)
        {
            switch (operat)
            {
                case "plus": return '+';
                case "minus": return '-';
                case "times": return '*';
                case "divided": return '/';
                default:
                    return '#';
            }
        }
    }
}
