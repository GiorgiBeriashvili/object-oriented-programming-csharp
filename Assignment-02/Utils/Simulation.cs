using System;
using System.Collections.Generic;
using Assignment_02.Models;
using Assignment_02.Models.Abstract;

namespace Assignment_02.Utils
{
    public static class Simulation
    {
        private static readonly List<Entity> _entities = new List<Entity>();
        
        public static Entity Add(Entity entity)
        {
            _entities.Add(entity);

            return entity;
        }
        
        public static void Simulate(Universe universe)
        {
            Print();
        }

        private static void Print()
        {
            foreach (var entity in _entities)
            {
                Console.WriteLine($"{entity}");
            }
        }
    }
}