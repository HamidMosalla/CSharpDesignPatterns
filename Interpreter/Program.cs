using System;
using System.Collections.Generic;
using Interpreter.Context;
using Interpreter.Expression;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string tokenString = "+ - 10 2 3";
            List<string> tokenList = new List<string>(tokenString.Split(' '));

            IExpression expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());    // (10 - 2) + 3 = 11

            tokenString = "- + 10 5 - 8 2";
            tokenList = new List<string>(tokenString.Split(' '));

            expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());   // (10 + 5) - (8 - 2) = 9
        }
    }
}
