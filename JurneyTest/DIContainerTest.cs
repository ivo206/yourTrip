using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripProj.Business.Infrastructure;
using TripProj.Business.Interfaces;
using TripProj.Business.Repositories;
using TripProj.Business.Exceptions;

namespace JurneyTest
{
    [TestClass]
    public class DIContainerTest
    {
        [TestMethod]
        public void can_resolve_object()
        {
            // Arrange
            var container = new DIContainer();

            // Act
            container.MapInstance<ITypeToResolve, ConcreteType>();
            var typeResolved = container.Get(typeof(ITypeToResolve));

            // Assert
            Assert.AreEqual(typeResolved.GetType(), typeof(ConcreteType));
            
        }

        [TestMethod]
        [ExpectedException(typeof(TypeNotSpecifiedException))]
        public void can_throw_exception_if_type_not_registred()
        {
            var container = new DIContainer();
            var typeResolved = container.Get(typeof(ITypeToResolveWithConstructorParams));
        }

        [TestMethod]
        public void can_resolve_object_with_parameters()
        {
            // Arrange
            var container = new DIContainer();

            // Act
            container.MapInstance<ITypeToResolve, ConcreteType>();
            container.MapInstance<ITypeToResolveWithConstructorParams, ConcreteTypeWithConstructorParams>();
            var typeResolved = container.Get(typeof(ITypeToResolveWithConstructorParams));

            // Assert
            Assert.AreEqual(typeResolved.GetType(), typeof(ConcreteTypeWithConstructorParams));
        }

        public interface ITypeToResolve
        {
        }

        public class ConcreteType : ITypeToResolve
        {
        }

        public interface ITypeToResolveWithConstructorParams
        {
        }

        public class ConcreteTypeWithConstructorParams : ITypeToResolveWithConstructorParams
        {
            public ConcreteTypeWithConstructorParams(ITypeToResolve typeToResolve)
            {
            }
        }
    }
}
