using DataLayer;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCms.Controllers
{
    public class AccountController : Controller
    {
        ILoginRepository _loginRepository;
        MyCmsContext db = new MyCmsContext();
        public AccountController()
        {
            _loginRepository = new LoginRepository(db);
        }
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
    }
}