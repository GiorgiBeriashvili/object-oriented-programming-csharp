using System;
using Assignment_02.Models;
using Assignment_02.Models.Enumerations;

namespace Assignment_02.Utils
{
    public static class Seeder
    {
        public static void Seed(Universe universe)
        {
            var cluster = (Cluster) Simulation.Add(new Cluster("The Local Cluster"));
            var galaxy = (Galaxy) Simulation.Add(new Galaxy("The Milky Way"));
            var starSystem = (StarSystem) Simulation.Add(new StarSystem("The Solar System", null));
            var star = (Star) Simulation.Add(new Star("Sun"));
            var planet = (Planet) Simulation.Add(new Planet("Earth"));
            var moon = (Moon) Simulation.Add(new Moon("Moon"));
            var continent = (Continent) Simulation.Add(new Continent("Europe", 746_419_440, 10_180_000, Hemisphere.NORTHERN));
            var country = (Country) Simulation.Add(new Country("Georgia", 3_716_858, 69_700, null, Currency.GEL, 510_96, 42.315407, 43.356892));
            var city = (City) Simulation.Add(new City("Tbilisi", 1_171_100, 504.2, -455, 607.25, 41.7151377, 44.827096));

            universe.Clusters.Add(cluster);
            cluster.Children.Add(galaxy);
            galaxy.Children.Add(starSystem);
            starSystem.Children.Add(planet);
            starSystem.Star = star;
            planet.Moons.Add(moon);
            planet.Continents.Add(continent);
            continent.Countries.Add(country);
            country.Cities.Add(city);
            country.Capital = city;
        }
    }
}