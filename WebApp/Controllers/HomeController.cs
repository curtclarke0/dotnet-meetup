using Notes.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Notes.WebApp.Controllers
{
    public class HomeController : Controller
    {
        List<Note> noteData = new List<Note>()
        {
            new Note {Title = "Note1", Summary = "Hello", Date = DateTime.Now},
            new Note {Title = "Note2", Summary = "Hello Meetup", Date = DateTime.Now},
            new Note {Title = "Note3", Summary = "Bye", Date = DateTime.Now}
        };

        // GET: Home
        public ActionResult Index()
        {
            return View(noteData);
        }

        public ActionResult Details(string title)
        {
            var note = noteData.FirstOrDefault(item => item.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            return View(note);
        }
    }
}