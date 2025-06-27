using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCms.Controllers
{
    public class HomeController : Controller
    {
        MyCmsContext db = new MyCmsContext();
        private IPageRepository _pageRepository;

        public HomeController()
        {
            _pageRepository = new PageRepository(db);
        }
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Slider()
        {
            return PartialView(_pageRepository.PagesInSlider());
        }

        public ActionResult CatSlider()
        {
            return PartialView(_pageRepository.PagesInSlider());
        }

        public ActionResult LatesNews()
        {
            return PartialView(_pageRepository.LatesNews());
        }
        public ActionResult MainNews()
        {
            return PartialView(_pageRepository.MainNews());
        }

        public ActionResult TopNews()
        {
            return PartialView();
        }
    }
}