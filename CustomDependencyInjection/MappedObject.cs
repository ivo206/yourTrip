
using CustomDependencyInjection.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDependencyInjection
{
    public class MappedObject
    {
        public Type TypeToMapTo { get; set; }
        public Type TypeBeforeMapping { get; set; }
        public object Instance { get; set; }

        public MappedObject(Type typeToMapTo, Type typeBeforeMapping)
        {
            TypeToMapTo = typeToMapTo;
            TypeBeforeMapping = typeBeforeMapping;
        }

        public void CreateInstance(params object[] args)
        {
            if(TypeToMapTo == null)
            {
                throw new TypeNotSpecifiedException("The object is mapped.");
            }
            var lengthArgs = args.Length;
            this.Instance = Activator.CreateInstance(this.TypeToMapTo, null);
        }

    }
}
