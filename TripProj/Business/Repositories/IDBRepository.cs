using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TripProj.Models;

namespace TripProj.Business.Repositories
{
    public interface IDBRepository: IDisposable
    {
        void Create(Journey curJourney);
        void Delete(int JourneyID);
        void Get(int JourneyID);
        void GetAll();
        void Update(int JourneyID);
    }
}