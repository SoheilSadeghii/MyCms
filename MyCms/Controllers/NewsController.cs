using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCms.Controllers
{
    public class NewsController : Controller
    {
        MyCmsContext db = new MyCmsContext();
        private IPageGroupRepository pageGroupRepository;

        public NewsController()
        {
            pageGroupRepository = new PageGroupRepository(db);
        }

        // GET: News
        public ActionResult ShowGroup()
        {
            return PartialView(pageGroupRepository.GetGroupsForView());
        }
    }
}