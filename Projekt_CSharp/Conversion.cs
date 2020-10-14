using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_CSharp
{
    public class Conversion
    {
        public double Parse(string userInput)
        {
            double result = 0;

            string[] words = userInput.Split(' ');

            // lists of value and func-objects 
            List<Value> values = new List<Value> { };
            List<Func> functions = new List<Func> { };


            foreach (var word in words)
            {
                if (isDigit(word))
                {
                    double number = ConvertStringToDigit(word);
                    values.Add(new Value(number));
                }
                else if (isOperator(word))
                {
                    char function = ConvertStringToChar(word);
                    functions.Add(new Func(function));
                }
            }



            //// Do multiple operations 

            double right = 0;
            double resultat = 0;
            double left = OpEval(values[0].GetValue(), functions[0].GetChar(), values[1].GetValue()); 
            result = left; 
            Console.WriteLine($"{values[0].GetValue()} {functions[0].GetChar()}  {values[1].GetValue()}  = {result}"); 

            for (int i = 1; i < functions.Count; i++) 
            {
                if (functions[i].GetChar() == '*')
                {
                    double left1 = values[0].GetValue();
                    double right1 = OpEval(values[1].GetValue(), functions[i].GetChar(), values[i + 1].GetValue());
                    double resultat1 = OpEval(left1, functions[0].GetChar(), right1);
                    Console.WriteLine($"{values[0].GetValue()} {functions[0].GetChar()} {values[1].GetValue()} {functions[1].GetChar()} {values[i + 1].GetValue()} = {resultat1}");
                    Console.ReadKey();
                }
                else

                right = values[i + 1].GetValue(); 
               resultat = OpEval(left, functions[i].GetChar(), right);
                result = resultat;
            Console.WriteLine($"{values[0].GetValue()} {functions[0].GetChar()} {values[1].GetValue()} {functions[1].GetChar()} {right} = {result}");
                Console.ReadKey();
            }
            




            //// checking what operator user entered 
            //switch (functions[0].GetChar())
            //{
            //    case '+':
            //        result = values[0].GetValue() + values[1].GetValue();
            //        break;
            //    case '-':
            //        result = values[0].GetValue() - values[1].GetValue();
            //        break;
            //    case '*':
            //        result = values[0].GetValue() * values[1].GetValue();
            //        break;
            //    case '/':
            //        result = values[0].GetValue() / values[1].GetValue();
            //        break;
            //}

            ////// printing the calculation and the result 

            //Console.WriteLine($"{values[0].GetValue()} {functions[0].GetChar()} {values[1].GetValue()} = {result}");




            return result;
        }



        double OpEval(double a, char op, double b) 
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
        public bool isDigit(string word)
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
        public bool isOperator(string word)
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

        public double ConvertStringToDigit(string word)
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

        public char ConvertStringToChar(string operat)
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