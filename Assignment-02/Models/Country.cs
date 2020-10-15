using System.Collections.Generic;
using Assignment_02.Models.Abstract;
using Assignment_02.Models.Enumerations;

namespace Assignment_02.Models
{
    class Country : GeographicalEntity
    {
        public List<City> Cities { get; } = new List<City>();

        public override double Area { get; protected set; }

        public override string Name { get; protected set; }

        public override int Population { get; protected set; }

        public double Elevation { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        internal City Capital { get; set; }

        internal Currency Currency { get; set; }

        public Country(string name, int population, double area, City capital, Currency currency, double elevation, double latitude, double longitude)
        {
            Area = area;
            Name = name;
            Population = population;
            Elevation = elevation;
            Latitude = latitude;
            Longitude = longitude;
            Capital = capital;
            Currency = currency;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Cities)}: {Cities}, {nameof(Area)}: {Area}, {nameof(Name)}: {Name}, {nameof(Population)}: {Population}, {nameof(Elevation)}: {Elevation}, {nameof(Latitude)}: {Latitude}, {nameof(Longitude)}: {Longitude}, {nameof(Capital)}: {Capital}, {nameof(Currency)}: {Currency}";
        }
    }
}