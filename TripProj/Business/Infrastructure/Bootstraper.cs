
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TripProj.Business.Interfaces;
using TripProj.Business.Repositories;
using TripProj.Controllers;

namespace TripProj.Business.Infrastructure
{
    public static class Bootstraper
    {
        public static void Configure(IDIContainer container)
        {
            container.MapInstance<JourneyController, JourneyController>();
            container.MapInstance<IJourneyRepository, FakeJourneyRepository>();
        }
    }
}