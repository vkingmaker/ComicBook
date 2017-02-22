using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookDiary.Data;
using ComicBookDiary.Models;

namespace ComicBookDiary.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {   
            return View(comic);
        }
    }
}