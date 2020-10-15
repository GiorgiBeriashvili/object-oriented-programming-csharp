using System.Collections.Generic;
using Assignment_02.Models.Abstract;
using Assignment_02.Models.Enumerations;

namespace Assignment_02.Models
{
    class Continent : GeographicalEntity
    {
        public List<Country> Countries { get; } = new List<Country>();

        public override double Area { get; protected set; }

        public override string Name { get; protected set; }

        public override int Population { get; protected set; }

        internal Hemisphere PrimaryHemisphere { get; set; }

        public Continent(string name, int population, double area, Hemisphere primaryHemisphere)
        {
            Area = area;
            Name = name;
            Population = population;
            PrimaryHemisphere = primaryHemisphere;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Countries)}: {Countries}, {nameof(Area)}: {Area}, {nameof(Name)}: {Name}, {nameof(Population)}: {Population}, {nameof(PrimaryHemisphere)}: {PrimaryHemisphere}";
        }
    }
}