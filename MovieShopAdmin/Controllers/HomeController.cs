using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieShopDll;
using MovieShopDll.Entities;

namespace MovieShopAdmin.Controllers
{
    public class HomeController : Controller
    {
        private IManager<Genre> _gm = 
            new DllFacade().GetGenreManager();
        public ActionResult Index()
        {
            if (_gm.Read().Count != 2)
            {
                _gm.Create(new Genre() {Name = "Banan"});
            }
            return View(_gm.Read());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}