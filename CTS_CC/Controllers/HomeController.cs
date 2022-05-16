using CTS_CC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CTS_CC.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext _context;

        // we need to initialied into a constructor
        public HomeController()
        {
            _context = new ApplicationDbContext(); // it is a disposible object
        }

        // to dispose the _context we need to overwride the base controller class

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMember(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
            return RedirectToAction("List", "Home");
        }

        public ActionResult List()
        {
            var members = _context.Members.ToList();
            if (members == null)
                return HttpNotFound();
            return View(members);
        }
        public ActionResult AddVote(int id)
        {
            var members = _context.Members.Where(c => c._id == id).FirstOrDefault();
            if (members == null)
                return HttpNotFound();
            members._isVoted = true;
            _context.Entry(members).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("List", "Home");
        }
    }
}