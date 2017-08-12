using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ahdh.Models;

namespace ahdh.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(Information.Context.Accounts);
        }
        public ActionResult Add()
        {
            
            return View();
        }
        public ActionResult Save(Account acc)
        {
            var selected = (x=> x.Id==acc.Id);

            if (selected != null)
            {
                selected.Name = acc.Name;
            }
            else 
            {
                Information.Context.Accounts.Add(acc);
            }
            return View();
        }
        public ActionResult Edit(int Id)
        {
            Information.Context.Accounts.FirstOrDefault(x => x.Id == Id);
            return View();
        }
        public ActionResult Delete(int Id)
        {
            var selected = Information;

            if(selected!=null)
            {
          
                Information.Context.Accounts.Remove(selected);
            }
            return RedirectToAction("Index");
        }
        
    }
}
