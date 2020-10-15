using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Projekt_CSharp
{
    public class Conversion
    {
        private string[] words;
        private List<Value> values;
        private List<Func> functions;

        public double Parse(string userInput)
        {
            double result = 0;
            double left;
            double right;
            int amountOfFunc = 0;

            // creating empty object-lists
            values = new List<Value> { };
            functions = new List<Func> { };

            // splitting the sentence to separate words - added to array
            words = userInput.Split(' ');

           

            // converting words to digits/chars and adding the objects to lists
            foreach (var word in words)
            {
                if (IsDigit(word))
                {
                    double number = ConvertStringToDigit(word);
                    values.Add(new Value(number));
                }
                else if (IsOperator(word))
                {
                    char function = ConvertStringToChar(word);
                    functions.Add(new Func(function));
                    amountOfFunc++;
                }
            }

            // calculating in different ways depending on amount of operators
            if (amountOfFunc == 1)
            {
                result = Calculate(values[0].GetValue(), functions[0].GetChar(), values[1].GetValue());
            }
            else if (amountOfFunc == 2)
            {
                if (functions[1].GetChar() == '*')
                {
                    left = Calculate(values[1].GetValue(), '*', values[2].GetValue());
                    right = values[0].GetValue();

                    result = Calculate(left, functions[0].GetChar(), right);
                }
                else
                {
                    left = Calculate(values[0].GetValue(), functions[0].GetChar(), values[1].GetValue());
                    right = values[2].GetValue();

                    result = Calculate(left, functions[1].GetChar(), right);
                }
            }
            else if (amountOfFunc == 3)
            {
                left = Calculate(values[0].GetValue(), functions[0].GetChar(), values[1].GetValue());
                right = Calculate(values[2].GetValue(), functions[2].GetChar(), values[3].GetValue());

                result = Calculate(left, functions[1].GetChar(), right);
            }
            else
            {
                Console.WriteLine("ERROR! Too many values/operators... Press any key to quit...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            // printing the calculation and result
            Console.Write($"RESULT >> {values[0].GetValue()} ");
            for (int i = 0; i < functions.Count; i++)
            {
                Console.Write($"{functions[i].GetChar()} ");
                Console.Write($"{values[i + 1].GetValue()} ");
            }
            Console.WriteLine($"= {result}");
            
            return result;
        }

        private double Calculate(double a, char op, double b) 
        { 
            switch (op) 
            { 
                case '*': 
                    return a * b; 
                case '/': 
                    return a / b; 
                case '+': 
                    return a + b; 
                case '-': 
                      return a - b; 
                default: throw new Exception(); 
            } 
        }

        // checking if a word is digit 
        private bool IsDigit(string word)
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
        private bool IsOperator(string word)
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

        private double ConvertStringToDigit(string word)
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

        private char ConvertStringToChar(string operat)
        {
            switch (operat)
            {
                case "plus": return '+';
                case "minus": return '-';
                case "times": return '*';
                case "divided": return '/';
                default:
                    return '0';
            }
        }
    }
}