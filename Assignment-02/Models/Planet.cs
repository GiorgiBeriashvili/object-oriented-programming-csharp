using System.Collections.Generic;
using Assignment_02.Models.Abstract;
using Assignment_02.Models.Interfaces;

namespace Assignment_02.Models
{
    internal class Planet : Entity, ICelestialBody
    {
        public List<Continent> Continents { get; } = new List<Continent>();
        public List<Moon> Moons { get; } = new List<Moon>();
        
        public string Name { get; set; }

        public Planet(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Continents)}: {Continents}, {nameof(Moons)}: {Continents}, {nameof(Name)}: {Name}";
        }
    }
}