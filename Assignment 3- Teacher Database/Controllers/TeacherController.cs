using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_3__Teacher_Database.Models;

namespace Assignment_3__Teacher_Database.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }


        // GET: /teacher/list
        public ActionResult List()
        {
            TeacherDataController controller = new TeacherDataController();
            
           IEnumerable<Teacher> Teachers = controller.ListTeachers();
            return View(Teachers);
        }

        // GET: /teacher/show/{id}
        public ActionResult show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher newTeacher = controller.FindTeacher(id);
            

            return View(newTeacher);
        }
    }
}