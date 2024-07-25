using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Interpreter
{
    // Example of an interpreter that includes an actual parser for converting the input into an expression tree. Look at how complex things are just to create an interpreter that can parse basic addition and subtraction input strings, e.g. "1 + 3 - 2".
    public class Interpreter2
    {
        private Context _context;

        public Interpreter2(Context context)
        {
            _context = context;
        }

        public int Interpret(string expression)
        {
            IExpression expressionTree = BuildExpressionTree(expression);
            return expressionTree.Interpret(_context);
        }

        // Parse the input into an expression tree. This parser only works with addition and subtraction. Handling multiplication, division and brackets requires more complexity; example: "1 + 3 * 4" requires 3 * 4 to be executed before adding the 1, due to BODMAS. Righting language/grammar parsers is very difficult to get right!
        private IExpression BuildExpressionTree(string input)
        {
            var tokens = input.Split(' ');
            var output = new Queue<string>();
            var operators = new Stack<string>();

            // Shunting Yard Algorithm to convert infix to postfix
            foreach (var token in tokens)
            {
                if (int.TryParse(token, out _))
                {
                    output.Enqueue(token);
                }
                else if (token == "+" || token == "-")
                {
                    while (operators.Count > 0 && (operators.Peek() == "+" || operators.Peek() == "-"))
                    {
                        output.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                output.Enqueue(operators.Pop());
            }

            var expressionStack = new Stack<IExpression>();

            while (output.Count > 0)
            {
                var token = output.Dequeue();

                if (int.TryParse(token, out int number))
                {
                    expressionStack.Push(new NumberExpression(number));
                }
                else if (token == "+" || token == "-")
                {
                    var right = expressionStack.Pop();
                    var left = expressionStack.Pop();

                    if (token == "+")
                    {
                        expressionStack.Push(new AdditionExpression(left, right));
                    }
                    else if (token == "-")
                    {
                        expressionStack.Push(new SubtractionExpression(left, right));
                    }
                }
            }

            return expressionStack.Pop();
        }
    }
}