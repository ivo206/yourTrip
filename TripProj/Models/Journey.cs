using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripProj.Models
{
    public class Journey
    {
        public int Id { get; set; }
        public LocationPoint StartPoint { get; set; }
        public LocationPoint EndPoint { get; set; }
        public TransportationEnum TransportationType { get; set; }
        public LevelEnum Level { get; set; }
        public int Rating { get; set; }
    }

    public enum TransportationEnum { Walk, Bike, Car, Public }
    public enum LevelEnum { Novice, Intermediate, Advanced, Hardcore }
}