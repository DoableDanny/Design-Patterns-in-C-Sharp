using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Interpreter
{
    public class Interpreter
    {
        private Context _context;

        public Interpreter(Context context)
        {
            _context = context;
        }

        public int Interpret(string expression)
        {
            IExpression expressionTree = BuildExpressionTree(expression);
            return expressionTree.Interpret(_context);
        }

        private IExpression BuildExpressionTree(string input)
        {
            // To demonstrate what this builder should do, we'll hard code the input and its result:
            input = "1 + 2 * 3"; // result should be 7

            // parser converts this input string into an Abstract Syntax Tree of objects ("expression tree")...
            // (parsers are complex and are easy to get wrong (see my Interpreter2 class), so we'll skip that step just create the tree directly. Of course, in real life, you'd need to a proper parser!)

            // Notice how our tree satisfies BODMAS:
            // 1 + 2 * 3
            // 2 * 3 = 6
            // 1 + 6 = 7
            IExpression expressionTree = new AdditionExpression(
                                                new MultiplicationExpression(
                                                    new NumberExpression("2"),
                                                    new NumberExpression("3")
                                                ),
                                                new NumberExpression("1")
                                            );

            return expressionTree;
        }
    }
}