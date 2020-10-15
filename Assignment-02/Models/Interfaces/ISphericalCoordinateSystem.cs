using System;
using System.Collections.Generic;
namespace Assignment_02.Models.Interfaces
{
    interface ISphericalCoordinateSystem
    {
        double Elevation { get; set; }
        double Latitude { get; set; }
        double Longitude { get; set; }
    }
}