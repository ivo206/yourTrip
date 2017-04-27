
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using TripProj.Business.Interfaces;

namespace TripProj.Business.Factories
{
    public class DICustomControllerFactory : DefaultControllerFactory
    {
        private readonly IDIContainer _dependencyContainer;

        public DICustomControllerFactory(IDIContainer container)
        {
            _dependencyContainer = container;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            IController controller = null;
            controller = _dependencyContainer.Get(controllerType) as Controller;
            return controller;
        }

    }
}