
using System.Collections.Generic;
using System.Web.Mvc;
using InventarioMeta.Models;

namespace InventarioMeta.Controllers
{
    public class MaquinasController : Controller
    {
        // GET: Maquinas
        public ActionResult Index()
        {
            var maquinas = new List<Maquinas>();
            return View(maquinas);
        }

        // GET: Maquinas/Details/5
        public ActionResult Details(int? id)
        {
            var maquina = new Maquinas();

            return View(maquina);
        }

        // GET: Maquinas/Create
        public ActionResult Create()
        {
            var maquina = new Maquinas
            {
                TiposArmazenamentos = ObterTiposArmazenamento()
            };

            return View(maquina);
        }

        public List<SelectListItem> ObterTiposArmazenamento()
        {
            var tiposArmazenamentos = new List<SelectListItem>
            {
                new SelectListItem { Text = "Selecione", Value = "" },
                new SelectListItem { Text = "HD", Value = "1" },
                new SelectListItem { Text = "SSD", Value = "2" },
                new SelectListItem { Text = "HD e SSD", Value = "3" }
            };

            return tiposArmazenamentos;
        }

        // POST: Maquinas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Maquinas maquinas)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
              
            }

            maquinas.TiposArmazenamentos = ObterTiposArmazenamento();
            return View(maquinas);
        }

        // GET: Maquinas/Edit/5
        public ActionResult Edit(int? id)
        {
            var maquina = new Maquinas
            {
                TiposArmazenamentos = ObterTiposArmazenamento()
            };

           // maquina.CodigoTipoArmazenamento = "3";

            return View(maquina);
        }

        // POST: Maquinas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Processador,RAM,SistemaOperacional,EspacoArmazenamento,AdaptadorWifi,Responsavel")] Maquinas maquinas)
        {
            if (ModelState.IsValid)
            {
                
                return RedirectToAction("Index");
            }
            return View(maquinas);
        }

        // GET: Maquinas/Delete/5
        public ActionResult Delete(int? id)
        {
            var maquina = new Maquinas();

            return View(maquina);
        }

        // POST: Maquinas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
