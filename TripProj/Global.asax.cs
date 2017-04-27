using CustomDependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using TripProj.Business.Factories;
using TripProj.Business.Infrastructure;
using TripProj.Business.Interfaces;
using TripProj.Business.Repositories;

namespace TripProj
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //MapInstances();
            RegisterCustomControllerFactory();
        }

        private void RegisterCustomControllerFactory()
        {
            //IControllerFactory factory = new CustomControllerFactory("TripProj.Controllers");
            DIContainer diContainer = new DIContainer();

            Bootstraper.Configure(diContainer);

            ControllerBuilder.Current.SetControllerFactory(new DICustomControllerFactory(diContainer));
        }

        //private void MapInstances()
        //{
        //    SimpleDIContainer.MapInstance<IJourneyRepository>(new FakeJourneyRepository());
        //}
    }
}
