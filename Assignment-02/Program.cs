using Assignment_02.Models;
using Assignment_02.Utils;

namespace Assignment_02
{
    internal static class Program
    {
        private static void Main()
        {
            var universe = Universe.Instance;

            Simulation.Add(universe);

            Seeder.Seed(universe);
            
            Simulation.Simulate(universe);
        }
    }
}
