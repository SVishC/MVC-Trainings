using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVCApplication.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            /*
#region ViewBag_Countries
            ViewBag.Countries = new List<string>() { 
            "India","Pakistan","Srilanka","Bangladesh"
            };
#endregion 
             */
            #region viewData_Countries
            ViewData["Countries"] = new List<string>() { 
            "India","Pakistan","Srilanka","Bangladesh"
            };
            #endregion
            return View();
        }

    }
}
