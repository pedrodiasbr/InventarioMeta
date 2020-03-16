using System;

namespace Biblioteca.Dependecia
{
    /// <summary>
    /// Responsável por resolver dependências.
    /// </summary>
    public interface IResolverDependencia
    {
        /// <summary>
        /// Resolver uma dependência.
        /// </summary>
        /// <typeparam name="T">Tipo para resolver.</typeparam>
        /// <returns>Objeto concreto instanciado.</returns>
        T Resolver<T>();

        /// <summary>
        /// Resolver uma dependência.
        /// </summary>
        /// <typeparam name="T">Tipo a ser retornado.</typeparam>
        /// <param name="type">Tipo para resolver.</param>
        /// <returns>Objeto concreto instanciado.</returns>
        T Resolver<T>(Type type);
    }
}
