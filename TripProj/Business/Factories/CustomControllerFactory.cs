using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using TripProj.Business.Infrastructure;
using TripProj.Business.Interfaces;
using TripProj.Business.Repositories;

namespace TripProj.Business.Factories
{
    public class CustomControllerFactory : IControllerFactory
    {
        private readonly string _controllerNamespace;

        public CustomControllerFactory(string controllerNamespace)
        {
            _controllerNamespace = controllerNamespace;
        }

        public IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            IController controller = null;

            if (requestContext.RouteData.Values["controller"].ToString() == "Journey")
            {
                
                //SimpleDIContainer.MapInstance<IJourneyRepository>(new FakeJourneyRepository());

                IJourneyRepository journey = SimpleDIContainer.Get<IJourneyRepository>();

                Type controllerType = Type.GetType(string.Concat(_controllerNamespace, ".", controllerName, "Controller"));
                controller = Activator.CreateInstance(controllerType, new[] { journey }) as Controller;
            }
            
            return controller;
        }

        public SessionStateBehavior GetControllerSessionBehavior(
          System.Web.Routing.RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }
        public void ReleaseController(IController controller)
        {
            IDisposable disposable = controller as IDisposable;
            if (disposable != null)
                disposable.Dispose();
        }
    }
}
