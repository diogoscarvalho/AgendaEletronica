using AgendaEletronica.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaEletronica.Controllers
{
    public class AgendaController : Controller
    {
        public ActionResult Index()
        {
            var contatos = new ContatoFactory().InicializeObject();
            return View(contatos);
        }

        public ActionResult Details(int id)
        {
            var contatos = new ContatoFactory().InicializeObject();

            return View(contatos.Where(x => x.IdContato == id).FirstOrDefault());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}