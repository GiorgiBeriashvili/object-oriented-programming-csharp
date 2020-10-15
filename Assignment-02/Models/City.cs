using Assignment_02.Models.Abstract;
using Assignment_02.Models.Interfaces;

namespace Assignment_02.Models
{
    internal class City : GeographicalEntity, ISphericalCoordinateSystem
    {
        private int _established;

        public sealed override double Area { get; protected set; }
        public sealed override string Name { get; protected set; }
        public sealed override int Population { get; protected set; }
        public double Elevation { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public City(string name, int population, double area, int established, double elevation, double latitude, double longitude)
        {
            Area = area;
            Name = name;
            Population = population;
            Elevation = elevation;
            Latitude = latitude;
            Longitude = longitude;
            _established = established;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(_established)}: {_established}, {nameof(Area)}: {Area}, {nameof(Name)}: {Name}, {nameof(Population)}: {Population}, {nameof(Elevation)}: {Elevation}, {nameof(Latitude)}: {Latitude}, {nameof(Longitude)}: {Longitude}";
        }
    }
}