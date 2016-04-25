using AgendaEletronica.Factory;
using AgendaEletronica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AgendaEletronica.Controllers
{
    public class EmailController : Controller
    {
        //
        // POST: /Email/1
        [HttpPost]
        public PartialViewResult Deletar(int id)
        {
            var contatos = new ContatoFactory().InicializeObject();

            var emails = contatos.Where(x => x.IdContato == id).Select(y => y.Emails).ToList();

            return PartialView(emails);
        }
	}
}