using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AL_Tahqeeq.Controllers
{
    public class HomeController : Controller
    {
        string DocumentIconPath = "/images/Thumbnails/document.png";
        string ContactUsIconPath = "/images/Thumbnails/contact_us.png";

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
            ViewBag.Message = "Contact Page.";
            ViewBag.TitleIconPath = ContactUsIconPath;
            return View();
        } 
        
        public ActionResult PrivacyPolicy()
        {
            //ViewBag.Message = "Privacy Policy";
            ViewBag.TitleIconPath = DocumentIconPath;
            return View();
        }

        public ActionResult Disclaimer()
        {
            //ViewBag.Message = "Disclaimer";
            ViewBag.TitleIconPath = DocumentIconPath;
            return View();
        }

        public ActionResult TermsAndConditions()
        {
            //ViewBag.Message = "Terms And Conditions";
            ViewBag.TitleIconPath = DocumentIconPath;
            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.TitleIconPath = DocumentIconPath;
            return View();
        }

    }
}