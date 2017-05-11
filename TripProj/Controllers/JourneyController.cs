using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TripProj.Business.Interfaces;

namespace TripProj.Controllers
{
    public class JourneyController : Controller
    {
        private IJourneyRepository _repository;

        public JourneyController(IJourneyRepository repo)
        {
            _repository = repo;
        }

        // GET: Journey
        public ActionResult Index()
        {
            var journeys = _repository.GetAllJourneys();
            if(journeys != null)
            {
                return Json(journeys, JsonRequestBehavior.AllowGet);
            }
            return Json("Probably throw the exception here!");
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            var journey = _repository.GetJourney(id);
            if (journey != null)
            {
                return Json(journey);
            }
            return Json("Probably throw the exception here!");
        }

    }
}