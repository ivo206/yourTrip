using CustomDependencyInjection.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TripProj.Business.Interfaces;
using TripProj.Business.Repositories;

namespace TripProj.Business.Infrastructure
{
    public class DIContainer : IDIContainer
    {
        private static IList<DIMapperObject> _dependencyMappings;

        static DIContainer()
        {
            _dependencyMappings = new List<DIMapperObject>();
        }

        public void MapInstance<TTypeBeforeMapping, TTypeToMapTo>()
        {
            _dependencyMappings.Add(new DIMapperObject(typeof(TTypeBeforeMapping), typeof(TTypeToMapTo)));
        }

        public object Get(Type typeBeforeMapping)
        {
            var objectMapper = _dependencyMappings.FirstOrDefault(t => t.TypeBeforeMapping == typeBeforeMapping);

            if (objectMapper == null)
            {
                throw new TypeNotSpecifiedException("The object is not mapped.");
            }

            //if(objectMapper.Instance == null)
            //{
                var parameters = GetParametersFromConstructor(objectMapper);
                objectMapper.CreateInstance(parameters.ToArray());
            //}

            return objectMapper.Instance;

        }

        public IEnumerable<object> GetParametersFromConstructor(DIMapperObject typeToMapTo)
        {
            IList<object> parameterList = new List<object>();
            var constructorInfo = typeToMapTo.TypeToMapTo.GetConstructors().First();
            foreach (var parameter in constructorInfo.GetParameters())
            {
                parameterList.Add(Get(parameter.ParameterType));
                //yield return Get(parameter.ParameterType);
            }
            return parameterList;
        }
    }
}