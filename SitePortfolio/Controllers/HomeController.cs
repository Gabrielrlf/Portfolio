using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitePortfolio.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Sobre mim";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Meus contatos";

			return View();
		}
		
		public ActionResult Portfolio()
		{
			ViewBag.Message = "Veja alguns dos meus trabalhos";
			
			return View();
		}
	}
}