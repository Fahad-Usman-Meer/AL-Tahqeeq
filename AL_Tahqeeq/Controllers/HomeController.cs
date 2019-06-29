using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AL_Tahqeeq.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Session["SelectedLanguage"] = enmLanguage.URDU.ToString();
            
            // use to remove current page from Related Articles
            Session["currPage"] = string.Empty; 
            
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
    }
}