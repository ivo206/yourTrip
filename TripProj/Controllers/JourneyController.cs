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
            return View();
        }
    }
}