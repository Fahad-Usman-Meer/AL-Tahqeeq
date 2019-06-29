using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AL_Tahqeeq.Controllers
{
    public class MaslaController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult M_001() // "Imam ul Ambia ﷺ ki dawat e quran."
        {
            ViewBag.Message = "Imam ul Ambia ﷺ ki dawat e quran.";
            return View();
        }

        /// <summary>
        /// viewName is actually file name of view
        /// </summary>
        /// <param name="viewName"></param>
        /// <returns></returns>
        public ActionResult GetView(string viewName)
        {
            if( ! string.IsNullOrEmpty(viewName))
            {
                ViewBag.englishName = Common.List_of_English_Maslas[viewName];
                ViewBag.urduName = Common.List_of_Urdu_Maslas[viewName];

                Session["currPage"] = viewName; // use to remove current page from Related Articles

                return View(viewName);
            }
            return View("404");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileResult GetPDF(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                string filePath = string.Format("/PDFs/{0}.pdf", fileName);
                return File(Server.MapPath(filePath), "application/pdf");
                //return File(Server.MapPath("/Test/Sample.pdf"), "application/pdf");
            }
            return null;
        }


    }
}