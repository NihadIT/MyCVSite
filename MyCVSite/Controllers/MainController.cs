using Microsoft.AspNetCore.Mvc;
using MyCVSite.Interfaces;
using MyCVSite.Models;
using MyCVSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCVSite.Controllers
{
    public class MainController : Controller
    {
        private Context db;
        public MainController(Context context)
        {
            db = context;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Summary()
        {
            return View();
        }

        public ViewResult List()
        {
            CoursesListViewModel viewModel = new CoursesListViewModel();
            viewModel.allCourses = db.Courses;
            return View(viewModel);
        }

        public Сourse GetCourse(int id) => db.Courses.FirstOrDefault(c => c.id == id);
    }
}
