using System.Collections.Generic;
using Assignment_02.Models.Abstract;
using Assignment_02.Models.Interfaces;

namespace Assignment_02.Models
{
    internal class StarSystem : Entity, ICelestialObject<Planet>
    {
        public List<Planet> Children { get; } = new List<Planet>();
        public string Name { get; set; }
        public Star Star { get; set; }

        public StarSystem(string name, Star star)
        {
            Name = name;
            Star = star;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Name)}: {Name}, {nameof(Star)}: {Star}, {nameof(Children)}: {Children}";
        }
    }
}