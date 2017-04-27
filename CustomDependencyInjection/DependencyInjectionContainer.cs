
using CustomDependencyInjection.Exceptions;
using CustomDependencyInjection.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDependencyInjection
{
    public class DependencyInjectionContainer : IDIContainer
    {

        private IList<MappedObject> _mappedObjects = new List<MappedObject>();

        public object Get(Type typeBeforeMapping)
        {
            var objectMappingType = _mappedObjects.FirstOrDefault(o => o.TypeBeforeMapping == typeBeforeMapping);
            if(objectMappingType == null)
            {
                throw new TypeNotSpecifiedException("You have not mapped this type.");
            }

            var mappedObjectInstance = getMappedObjectInstance(objectMappingType);

            return mappedObjectInstance;
        }

        public object getMappedObjectInstance(MappedObject objectMappingType)
        {
            if (objectMappingType.Instance == null)
            {
                var parameters = ResolveConstructorParameters(objectMappingType);
                objectMappingType.CreateInstance(parameters);
            }

            return objectMappingType.Instance;
        }

        public IEnumerable<object> ResolveConstructorParameters(MappedObject objectMappingType) {
            var constructorInfo = objectMappingType.TypeToMapTo.GetConstructors().First();
            foreach (var parameter in constructorInfo.GetParameters())
            {
                yield return Get(parameter.ParameterType); 
            }
        }

        public void MapDependencies<TTypeBeforeMaping, TTypeToMapTo>()
        {
            _mappedObjects.Add(new MappedObject(typeof(TTypeToMapTo), typeof(TTypeBeforeMaping)));
        }
    }
}
