using System;

namespace Biblioteca.Dependecia
{
    /// <summary>
    /// Resolver dependências.
    /// OBS: Essa classe deve ser inicializada (método Initialize) antes de ser utilizada.
    /// </summary>
    public static class IoC
    {
        #region Fields

        private static IResolverDependencia _resolverDependencia;

        #endregion

        #region Methods

        /// <summary>
        /// Inicializa essa classe de inversão de controle.
        /// </summary>
        /// <param name="resolverDependencia">Classe creceta a ser utilizada para resolver as dependências</param>
        public static void Initialize(IResolverDependencia resolverDependencia)
        {
            _resolverDependencia = resolverDependencia;
        }

        /// <summary>
        /// Resolver uma dependência.
        /// </summary>
        /// <typeparam name="T">Tipo para resolver</typeparam>
        /// <returns>Objeto concreto instanciado.</returns>
        public static T Resolver<T>()
        {
            return _resolverDependencia.Resolver<T>();
        }

        /// <summary>
        /// Resolver uma dependência.
        /// </summary>
        /// <typeparam name="T">Tipo a ser retornado.</typeparam>
        /// <param name="type">Tipo para resolver.</param>
        /// <returns>Objeto concreto instanciado.</returns>
        public static T Resolver<T>(Type type)
        {
            return _resolverDependencia.Resolver<T>(type);
        }

        /// <summary>
        /// Resolver uma dependência.
        /// </summary>
        /// <param name="type">Tipo a ser resolvido</param>
        /// <returns>Objeto concreto instanciado</returns>
        public static object Resolver(Type type)
        {
            return Resolver<object>(type);
        }
        
        #endregion
    }
}
