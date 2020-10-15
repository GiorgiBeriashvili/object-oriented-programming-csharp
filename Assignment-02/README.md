# Usage

Sample usage scenario after running the `dotnet run` command:

```plaintext
Entity #0 of type [Assignment_02.Models.Universe], Clusters: System.Collections.Generic.List`1[Assignment_02.Models.Cluster]
Entity #1 of type [Assignment_02.Models.Cluster], Name: The Local Cluster, Children: System.Collections.Generic.List`1[Assignment_02.Models.Galaxy]
Entity #2 of type [Assignment_02.Models.Galaxy], Name: The Milky Way, Children: System.Collections.Generic.List`1[Assignment_02.Models.StarSystem]
Entity #3 of type [Assignment_02.Models.StarSystem], Name: The Solar System, Star: Entity #4 of type [Assignment_02.Models.Star], Name: Sun, Children: System.Collections.Generic.List`1[Assignment_02.Models.Planet]
Entity #4 of type [Assignment_02.Models.Star], Name: Sun
Entity #5 of type [Assignment_02.Models.Planet], Continents: System.Collections.Generic.List`1[Assignment_02.Models.Continent], Moons: System.Collections.Generic.List`1[Assignment_02.Models.Continent], Name: Earth
Entity #6 of type [Assignment_02.Models.Moon], Name: Moon
Entity #7 of type [Assignment_02.Models.Continent], Countries: System.Collections.Generic.List`1[Assignment_02.Models.Country], Area: 10180000, Name: Europe, Population: 746419440, PrimaryHemisphere: NORTHERN
Entity #8 of type [Assignment_02.Models.Country], Cities: System.Collections.Generic.List`1[Assignment_02.Models.City], Area: 69700, Name: Georgia, Population: 3716858, Elevation: 51096, Latitude: 42.315407, Longitude: 43.356892, Capital: Entity #9 of type [Assignment_02.Models.City], _established: -455, Area: 504.2, Name: Tbilisi, Population: 1171100, Elevation: 607.25, Latitude: 41.7151377, Longitude: 44.827096, Currency: GEL
Entity #9 of type [Assignment_02.Models.City], _established: -455, Area: 504.2, Name: Tbilisi, Population: 1171100, Elevation: 607.25, Latitude: 41.7151377, Longitude: 44.827096
```