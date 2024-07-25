using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1.src.DesignPatterns.Behavioral.Interpreter
{
    public class MultiplicationExpression : IExpression
    {
        private IExpression _left;
        private IExpression _right;

        public MultiplicationExpression(IExpression left, IExpression right)
        {
            this._left = left;
            this._right = right;
        }

        public int Interpret(Context context)
        {
            return _left.Interpret(context) * _right.Interpret(context);
        }
    }
}