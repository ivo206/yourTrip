using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TripProj.Business.Interfaces;
using TripProj.Models;

namespace TripProj.Business.Repositories
{
    public class FakeJourneyRepository : IJourneyRepository
    {
        public IList<Journey> MockJourneys { get; set; }

        public FakeJourneyRepository()
        {
            MockJourneys = new List<Journey>()
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

        public void AddJourney(Journey newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeleteJourney(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Journey> GetAllJourneys()
        {
            return MockJourneys as IEnumerable<Journey>;
        }

        public Journey GetJourney(int id)
        {
            return MockJourneys.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateJourney(int id, Journey updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}