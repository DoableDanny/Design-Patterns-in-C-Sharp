using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Interpreter
{
    public class SubtractionExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public SubtractionExpression(IExpression left, IExpression right)
        {
            _left = left;
            _right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) - _right.Interpret(context);
        }
    }
}