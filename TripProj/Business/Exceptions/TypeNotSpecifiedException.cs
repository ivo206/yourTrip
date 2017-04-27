using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TripProj.Business.Exceptions
{
    public class TypeNotSpecifiedException : Exception
    {
        public TypeNotSpecifiedException(string message) : base(message)
        {

        }
    }
}