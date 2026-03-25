using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Interpreter
{
    public class GreaterThanExpression : IExpression
    {
        private string _var;
        private int _value;
        public GreaterThanExpression(string var, int value) { _var = var; _value = value; }
        public bool Interpret(Context context) => context.Variables[_var] > _value;
    }
}
