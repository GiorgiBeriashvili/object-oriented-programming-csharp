namespace Assignment_02.Models.Abstract
{
    abstract class GeographicalEntity : Entity
    {
        public abstract double Area { get; protected set; }
        public abstract string Name { get; protected set; }
        public abstract int Population { get; protected set; }
    }
}