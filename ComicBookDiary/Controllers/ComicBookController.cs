using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComicBookDiary.Models;

namespace ComicBookDiary.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            ComicBook comicBook = new ComicBook
            {
                SeriesTitle = "The Amazing Spider-man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final Issue! Witness the final hours of Doctor Octopus' Life and his one,Last,great act of revenge! Even if Spider Man Survives...<strong>Will Peter Parker</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name="Dan Sloot" , Role="Script"},
                    new Artist() { Name="Humberto Ramos" , Role="Pencils"},
                    new Artist() { Name="Victor Olazaba" , Role="Inks"},
                    new Artist() { Name="Elgar Delgado" , Role="Colors"},
                    new Artist() { Name="Letters" , Role="Monday Victor"}
                },

            };

            return View(comicBook);
        }
    }
}