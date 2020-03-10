
using System;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;
using InventarioMeta.Models;
using InventarioMeta.Models.Autenticacao;


namespace InventarioMeta.Controllers
{
    [AllowAnonymous]
    public class AutenticacaoController : Controller
    {
        public ActionResult Login(string urlRetorno)
        {
            var model = new LoginModel
            {
                UrlRetorno = urlRetorno
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            return View(model);
        }

       
    }
       
}
