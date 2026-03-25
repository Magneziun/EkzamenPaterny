using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Composite
{
    public class SimpleBuilding : ICityComponent
    {
        public string Address { get; set; }
        public void Display(int indent = 0) => Console.WriteLine(new string(' ', indent) + $"Здание {Address}");
    }
}
