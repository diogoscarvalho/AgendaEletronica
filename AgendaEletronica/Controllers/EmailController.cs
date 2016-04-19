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
        // GET: /Email/
        public ActionResult Index(Email model)
        {
            return View();
        }
	}
}