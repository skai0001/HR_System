using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkaikySolutions.DAL;
using SkaikySolutions.ViewModels;

namespace SkaikySolutions.Controllers
{
    public class HomeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Data()
        {
            IQueryable<EnrollmentDateGroup> data = from student in db.Employees
                      group student by student.EnrollmentDate into dateGroup
                      select new EnrollmentDateGroup()
                      {
                          EnrollmentDate = dateGroup.Key,
                          EmployeeCount = dateGroup.Count()
                      };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}