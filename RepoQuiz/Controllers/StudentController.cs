using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoQuiz.DAL;
using RepoQuiz.Models;

namespace RepoQuiz.Controllers
{
    public class StudentController : Controller
    {
        private StudentRepository repo = new StudentRepository();

        public ActionResult Index()
        {
            ViewBag.Students = repo.GetStudents();
            return View();
        }

        public ActionResult Details(int id)
        {
            //Student target_student = repo.GetStudentById(id);

            //ViewBag.Students = target_student;

            return View();
        }

    }
}
