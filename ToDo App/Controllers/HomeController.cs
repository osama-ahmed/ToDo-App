using System;
using System.Linq;
using System.Web.Mvc;
using ToDo_App.Models;

namespace ToDo_App.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var notes = _context.Notes
                .OrderByDescending(n => n.date)
                .ToList();

            return View(notes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Note note)
        {
            note.date = DateTime.Now;
            _context.Notes.Add(note);
            _context.SaveChanges();

            return RedirectToAction("Index","Home");
        }
    }
}