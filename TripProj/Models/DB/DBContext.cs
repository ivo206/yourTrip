using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TripProj.Models.DB
{
    public class JourneyContext: DbContext
    {
        public JourneyContext():base("DefaultConnection")
        {
        }

        public JourneyContext(string connString) : base(connString)
        {
        }
        public DbSet<Journey> Journeys { get; set; }
    }
}