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
            try
            {
                if (!string.IsNullOrEmpty(viewName))
                {
                    ViewBag.englishName = Common.List_of_English_Maslas[viewName];
                    ViewBag.urduName = Common.List_of_Urdu_Maslas[viewName];
                    ViewBag.TitleIconPath = Common.List_of_Thumbnails_Path[viewName];

                    Session["currPage"] = viewName; // use to remove current article from Related Articles

                    return View(viewName);
                }
            }
            catch (Exception ex)
            {
             //   throw ex;
            }

            ViewBag.TitleIconPath = Common.List_of_Thumbnails_Path["error"];
            return View("error");
        }

        

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public FileResult GetPDF(string fileName)
        {
            string filePath = "/PDFs/error.html"; // default
            try
            {
                if (!string.IsNullOrEmpty(fileName))
                {
                    filePath = string.Format("/PDFs/{0}.pdf", fileName);
                    return File(Server.MapPath(filePath), "application/pdf");
                    //return File(Server.MapPath("/Test/Sample.pdf"), "application/pdf");
                }
            }
            catch (Exception ex)
            {
               // throw ex;
                //filePath = ;
            }
            
            return File(Server.MapPath(filePath), "html");
        }

        private ViewResult ShowError()
        {
            return View("Error");
        }


    }
}