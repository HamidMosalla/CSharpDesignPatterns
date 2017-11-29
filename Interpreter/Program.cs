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
            /*
             * more info: https://sourcemaking.com/design_patterns/interpreter
             * https://www.codeproject.com/Articles/186183/Interpreter-Design-Pattern
            Intent
            Given a language, define a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
            Map a domain to a language, the language to a grammar, and the grammar to a hierarchical object-oriented design.

            Problem
            A class of problems occurs repeatedly in a well-defined and well-understood domain.
            If the domain were characterized with a "language",
            then problems could be easily solved with an interpretation "engine".
             */

            string tokenString = "+ - 10 2 3";
            var tokenList = new List<string>(tokenString.Split(' '));
            IExpression expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());    // (10 - 2) + 3 = 11


            tokenString = "- + 10 5 - 8 2";
            tokenList = new List<string>(tokenString.Split(' '));
            expression = new TokenReader().ReadToken(tokenList);
            Console.WriteLine(expression.Interpret());   // (10 + 5) - (8 - 2) = 9
        }
    }
}
