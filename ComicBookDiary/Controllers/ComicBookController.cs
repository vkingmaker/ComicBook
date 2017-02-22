using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookDiary.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.Description = "The Lord is Always Good Even in the days of trouble";
            ViewBag.Price = 700;

            return View();
        }
    }
}