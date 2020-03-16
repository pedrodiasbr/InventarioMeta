using System;
using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace Biblioteca.Dependecia
{
    public class ResolverDependencia : IResolverDependencia, IDisposable
    {
        #region Fields

        private readonly IUnityContainer _container;

        #endregion

        #region Constructors

        public ResolverDependencia()
            : this(new UnityContainer())
        {
            var configSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            configSection.Containers.Default.Configure(_container);
        }

        public ResolverDependencia(IUnityContainer unityContainer)
        {
            _container = unityContainer;
        }

        #endregion

        #region IResolverDependencia Members

        public T Resolver<T>()
        {
            return _container.Resolve<T>();
        }

        public T Resolver<T>(Type type)
        {
            return (T)_container.Resolve(type);
        }

        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            if (_container != null)
            {
                _container.Dispose();
            }
        }

        #endregion
    }
}
