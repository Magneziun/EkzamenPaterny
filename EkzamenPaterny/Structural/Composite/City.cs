using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Composite
{
    public class City : ICityComponent
    {
        private List<ICityComponent> _children = new();
        public void Add(ICityComponent component) => _children.Add(component);
        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + "Город");
            foreach (var child in _children) child.Display(indent + 2);
        }
    }
}
