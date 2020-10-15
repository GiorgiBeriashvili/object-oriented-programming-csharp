using System.Collections.Generic;
using Assignment_02.Models.Abstract;

namespace Assignment_02.Models.Interfaces
{
    internal interface ICelestialObject<T> where T: Entity
    {
        List<T> Children { get; }
    }
}