using System.Collections.Generic;
using Assignment_02.Models.Abstract;
using Assignment_02.Models.Interfaces;

namespace Assignment_02.Models
{
    internal class Cluster : Entity, ICelestialObject<Galaxy>
    {
        public List<Galaxy> Children { get; } = new List<Galaxy>();
        public string Name { get; set; }

        public Cluster(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Name)}: {Name}, {nameof(Children)}: {Children}";
        }
    }
}