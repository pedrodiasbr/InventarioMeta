using Biblioteca.Dependecia;
using Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventarioMeta.Fabrica
{
    public class Repositorios
    {
        private static IMaquinaRepositorio _maquinaRepositorio;
        public static IMaquinaRepositorio MaquinaRepositorio
        {
            get { return _maquinaRepositorio ?? IoC.Resolver<IMaquinaRepositorio>(); }
        }
    }
}