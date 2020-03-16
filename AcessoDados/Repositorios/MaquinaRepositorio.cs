using Dominio.Entidades;
using Dominio.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AcessoDados.Repositorios
{
    public class MaquinaRepositorio : IMaquinaRepositorio
    {
        private static void VerificaMaquinaExistente(tbMaquinas maquina)
        {
            using (var modeloEntidades = new ModeloDadosEntities())
            {
                if (modeloEntidades.tbMaquinas.Where(r => r.Id != maquina.Id).Any())
                {
                    throw new Exception($"Esta máquina não existe, favor cadastra-la");
                }
            }
        }
        public void Alterar(tbMaquinas maquina)
        {
            try
            {
                using (var modeloEntidades = new ModeloDadosEntities())
                {
                    VerificaMaquinaExistente(maquina);

                    var maquinaExistente = modeloEntidades.tbMaquinas.Where(r => r.Id == maquina.Id).FirstOrDefault();
                    maquinaExistente.AdaptadorWifi = maquina.AdaptadorWifi;
                    maquinaExistente.Processador = maquina.Processador;
                    maquinaExistente.RAM = maquina.RAM;
                    maquinaExistente.SistemaOperacional = maquina.SistemaOperacional;
                    maquinaExistente.EspacoArmazenamento = maquina.EspacoArmazenamento;
                    maquinaExistente.CodigoTipoArmazenamento = maquina.CodigoTipoArmazenamento;
                    modeloEntidades.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public tbMaquinas Obter(int id)
        {

            tbMaquinas tbMaquinas;

            using (var modeloEntidades = new ModeloDadosEntities())
            {

                tbMaquinas = modeloEntidades.tbMaquinas.Where(r => r.Id.Equals(id)).FirstOrDefault();
                if (tbMaquinas == null)
                    throw new Exception("Maquina não encontrada.");
            }

            return tbMaquinas;
        }


        public IList<tbMaquinas> ObterTodos()
        {
            List<tbMaquinas> tbMaquinas;

            using (var modeloEntidades = new ModeloDadosEntities())
            {
                tbMaquinas = modeloEntidades.tbMaquinas.OrderBy(r => r.SistemaOperacional).ToList();
            }

            return tbMaquinas;
        }

        public void Excluir(int id)
        {
            try
            {
                using (var modeloEntidades = new ModeloDadosEntities())
                {
                    var Maquina = modeloEntidades.tbMaquinas.Where(r => r.Id.Equals(id)).FirstOrDefault();
                    modeloEntidades.tbMaquinas.Remove(Maquina);
                    modeloEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public void Salvar(tbMaquinas maquina)
        {
            try
            {
                using (var modeloEntidades = new ModeloDadosEntities())
                {

                    modeloEntidades.tbMaquinas.Add(maquina);
                    modeloEntidades.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
