using NurseLoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NurseLoginApp.Controllers
{
    public class NurseController : Controller
    {
        private NurseDbContext db = new NurseDbContext();

        // GET: Login Page
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            var nurse = db.Nurses.SingleOrDefault(n => n.Username == username && n.Password == password);
            if (nurse != null)
            {
                // Redirect to View Appointments if login is successful
                return RedirectToAction("ViewAppointments");
            }

            ViewBag.ErrorMessage = "Invalid Username or Password";
            return View();
        }
        public ActionResult ViewAppointments()
        {
            return View();
        }

        // GET: Edit Prescription
        public ActionResult EditPrescription()
        {
            return View();
        }
        // GET: Nurse
        public ActionResult Logout()
        {
            // Clear session or authentication information if used (optional)
            // Redirect to Login page
            return RedirectToAction("Login");
        }
    }
}