using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TripProj.Models.DB
{
    public class JourneyContext: DbContext
    {
        public DbSet<Journey> Journeys { get; set; }
    }
}