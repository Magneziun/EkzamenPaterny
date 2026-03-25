using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Interpreter
{
    public interface IExpression
    {
        bool Interpret(Context context);
    }
}
