using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripProj.Models;

namespace TripProj.Business.Interfaces
{
    public interface IJourneyRepository
    {
        IEnumerable<Journey> GetAllJourneys();

        Journey GetJourney(int id);

        void AddJourney(Journey newPerson);

        void UpdateJourney(int id, Journey updatedPerson);

        void DeleteJourney(int id);
    }
}
