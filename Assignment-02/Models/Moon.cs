using Assignment_02.Models.Abstract;
using Assignment_02.Models.Interfaces;

namespace Assignment_02.Models
{
    class Moon : Entity, ICelestialBody
    {
        public string Name { get; set; }
        
        public Moon(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Name)}: {Name}";
        }
    }
}