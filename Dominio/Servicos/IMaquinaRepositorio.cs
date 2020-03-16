using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Servicos
{
    public interface IMaquinaRepositorio
    {
        void Salvar(tbMaquinas maquina);

        void Alterar(tbMaquinas maquinao);

        void Excluir(int id);

        IList<tbMaquinas> ObterTodos();

        tbMaquinas Obter(int id);
    }
}
