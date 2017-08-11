using Notes.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.IO;
using Notes.WebApp.Services;

namespace Notes.WebApp.Controllers
{
    public class HomeController : Controller
    {
        NotesRepository notesRepository;

        public HomeController()
        {
            notesRepository = new NotesRepository();
        }

        // GET: Home
        public ActionResult Index()
        {
            var notes = notesRepository.GetAll();

            return View(notes);
        }

        public ActionResult Details(Guid id)
        {
            var note = notesRepository.Get(id);

            return View(note);
        }

        public ActionResult Update(Note note)
        {
            notesRepository.AddOrUpdate(note);

            return RedirectToAction("Index");
        }
    }
}