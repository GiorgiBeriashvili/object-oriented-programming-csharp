using System;

namespace Assignment_02.Models.Abstract
{
    public abstract class Entity
    {
        private static int _id = 0;

        public int Id { get; }

        protected Entity()
        {
            Id = _id++;
        }

        public override bool Equals(object other)
        {
            return other is Entity entity && Id.Equals(entity.Id);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return $"Entity #{Id} of type [{GetType()}]";
        }
    }
}