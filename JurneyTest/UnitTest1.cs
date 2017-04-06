using System;
using TripProj.Controllers;
using TripProj.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace JourneyTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void isReturnAllJourneys()
        {
            //Set up of the test
            //JourneyController controller = new JourneyController();

            //controller.Index();

            //action of the test

            //test

        }

        public List<Journey> dummyData = new List<Journey>()
        {
            new Journey() {
                Id=1,
                StartPoint = new LocationPoint(),
                EndPoint = new LocationPoint(),
                TransportationType = TransportationEnum.Bike,
                Level = LevelEnum.Advanced,
                Rating =1
            },
            new Journey() {
                Id=2,
                StartPoint = new LocationPoint(),
                EndPoint = new LocationPoint(),
                TransportationType = TransportationEnum.Car,
                Level = LevelEnum.Novice,
                Rating =1
            },
            new Journey() {
                Id=3,
                StartPoint = new LocationPoint(),
                EndPoint = new LocationPoint(),
                TransportationType = TransportationEnum.Public,
                Level = LevelEnum.Hardcore,
                Rating =1
            }
        };
    }
}
