using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Notes.WebApp.Models;

namespace Notes.WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = new Data()
            {
                Message = "Hello from Meetup",
            };

            data.Message = "Another message";

            return View(data);
        }
    }
}