using System;
using System.Collections.Generic;
using System.Text;

namespace EkzamenPaterny.Creational.Builder
{
    public class BuildingBuilder
    {
        private Building _building = new();
        public BuildingBuilder SetName(string name) { _building.Name = name; return this; }
        public BuildingBuilder SetFloors(int floors) { _building.Floors = floors; return this; }
        public BuildingBuilder SetParking(bool hasParking) { _building.HasParking = hasParking; return this; }
        public Building Build() { return _building; }
    }

}
