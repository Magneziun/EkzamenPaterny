using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Behavioral.Interpreter
{
    public class Context
    {
        public Dictionary<string, int> Variables { get; set; } = new();
    }

}
