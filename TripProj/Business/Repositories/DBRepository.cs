using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TripProj.Models;
using TripProj.Models.DB;

namespace TripProj.Business.Repositories
{
    public class DBRepository : IDBRepository
    {
        private DbContext _dbcontext;

        public DBRepository()
        {
            _dbcontext = new JourneyContext();

        }

        public void Create(Journey curJourney)
        {

            throw new NotImplementedException();
        }

        public void Delete(int JourneyID)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Get(int JourneyID)
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int JourneyID)
        {
            throw new NotImplementedException();
        }

    }
}