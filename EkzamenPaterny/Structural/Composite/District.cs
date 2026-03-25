using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Structural.Composite
{
    public class District : ICityComponent
    {
        public string Name { get; set; }
        private List<ICityComponent> _buildings = new();
        public void Add(ICityComponent building) => _buildings.Add(building);
        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + $"Район {Name}");
            foreach (var b in _buildings) b.Display(indent + 2);
        }
    }
}
