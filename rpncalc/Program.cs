using System;
using System.Collections.Generic;

namespace rpncalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<double>();

            while (true)
            {
                Console.Write("> ");
                var input = Console.ReadLine();

                double number;
                if (double.TryParse(input, out number))
                {
                    stack.Push(number);
                }
                else if (input == "+")
                {
                    var value1 = stack.Pop();
                    var value2 = stack.Pop();
                    stack.Push(value1 + value2);
                }
                Console.WriteLine(stack.AsString());
            }
        }
    }
}
