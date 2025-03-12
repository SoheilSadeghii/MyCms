using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCms.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult ShowGroup()
        {
            return PartialView();
        }
    }
}