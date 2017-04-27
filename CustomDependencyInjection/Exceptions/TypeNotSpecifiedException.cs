using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDependencyInjection.Exceptions
{
    public class TypeNotSpecifiedException : Exception
    {
        public TypeNotSpecifiedException(string message) : base(message)
        {

        }
    }
}
