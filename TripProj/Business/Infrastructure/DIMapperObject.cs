using System.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TripProj.Business.Exceptions;

using TripProj.Controllers;

namespace TripProj.Business.Infrastructure
{
    public class DIMapperObject
    {
        public Type TypeToMapTo { get; set; }
        public Type TypeBeforeMapping { get; set; }
        public object Instance { get; set; }

        public DIMapperObject(Type typeBeforeMapping, Type typeToMapTo)
        {
            TypeToMapTo = typeToMapTo;
            TypeBeforeMapping = typeBeforeMapping;
        }

        public void CreateInstance(object[] args = null)
        {
            if (TypeToMapTo == null)
            {
                throw new TypeNotSpecifiedException("The object is mapped.");
            }
            
            this.Instance = Activator.CreateInstance(this.TypeToMapTo, args);
        }
    }
}