using System;
using TripProj.Controllers;
using TripProj.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TripProj.Business.Infrastructure;
using TripProj.Business.Interfaces;
using TripProj.Business.Repositories;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Linq;
//using System.Web.Mvc;


namespace JourneyTest
{
    [TestClass]
    public class JourneyTest
    {
        private IDIContainer _container;

        [TestInitialize]
        public void Setup()
        {
            _container = new DIContainer();
            _container.MapInstance<IJourneyRepository, FakeJourneyRepository>();
        }

        [TestMethod]
        public void can_return_all_journeys()
        {
            // Arrange
            IJourneyRepository repository = _container.Get(typeof(IJourneyRepository)) as IJourneyRepository;
            JourneyController controller = new JourneyController(repository);

            // Act - process the route
            var journeyData = ((JsonResult)controller.Index()).Data as IEnumerable<Journey>;

            // Assert
            Assert.IsTrue(journeyData.Count() == 3);
            Assert.IsTrue(journeyData.FirstOrDefault(x => x.Id == 1) != null);
            Assert.IsTrue(journeyData.FirstOrDefault(x => x.Id == 2) != null);
            Assert.IsTrue(journeyData.FirstOrDefault(x => x.Id == 3) != null);

        }

        [TestMethod]
        public void can_return_a_journey_with_id()
        {
            // Arrange
            IJourneyRepository repository = _container.Get(typeof(IJourneyRepository)) as IJourneyRepository;
            JourneyController controller = new JourneyController(repository);

            // Act - process the route
            var journeyData = ((JsonResult)controller.Index(3)).Data as Journey;

            // Assert
            Assert.IsTrue(journeyData.Id == 3);
            

        }
    }
}
