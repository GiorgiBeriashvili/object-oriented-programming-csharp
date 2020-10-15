using System;
using System.Collections.Generic;
using Assignment_02.Models.Abstract;

namespace Assignment_02.Models
{
    public class Universe : Entity
    {
        private static readonly List<Cluster> _clusters = new List<Cluster>();

        internal List<Cluster> Clusters => _clusters;

        private static readonly Lazy<Universe> _universe = new Lazy<Universe>(() => new Universe());

        public static Universe Instance => _universe.Value;

        private Universe() { }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Clusters)}: {Clusters}";
        }
    }
}