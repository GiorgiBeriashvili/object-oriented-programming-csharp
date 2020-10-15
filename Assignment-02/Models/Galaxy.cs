using System.Collections.Generic;
using Assignment_02.Models.Abstract;
using Assignment_02.Models.Interfaces;

namespace Assignment_02.Models
{
    internal class Galaxy : Entity, ICelestialObject<StarSystem>
    {
        public List<StarSystem> Children { get; } = new List<StarSystem>();

        public string Name { get; set; }

        public Galaxy(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Name)}: {Name}, {nameof(Children)}: {Children}";
        }
    }
}