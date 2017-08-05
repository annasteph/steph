using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ahdh.Models;

namespace ahdh.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            Information i = new Information();
            return View(i.Accounts);
        }
        public ActionResult Add()
        {
            
            return View();
        }
        public ActionResult Save(Account acc)
        {

            return View();
        }
    }
}
