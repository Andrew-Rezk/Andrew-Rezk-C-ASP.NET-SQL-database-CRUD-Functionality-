using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_3__Teacher_Database.Models;
using System.Diagnostics;

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
        public ActionResult List(string searchKey = null)
        {
            TeacherDataController controller = new TeacherDataController();

            IEnumerable<Teacher> Teachers = controller.ListTeachers(searchKey);
            return View(Teachers);
        }

        // GET: /teacher/show/{id}
        public ActionResult show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher SelectedTeacher = controller.FindTeacher(id);


            return View(SelectedTeacher);
        }

        // GET: /teacher/deleteconfirm/{id}
        public ActionResult deleteconfirm(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher newTeacher = controller.FindTeacher(id);


            return View(newTeacher);
        }

        // POST: /Teacher/DELETE/{id}

        public ActionResult Delete(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            controller.DeleteTeacher(id);
            return RedirectToAction("List");
        }

        // GET: /Teacher/New
        public ActionResult New()
        {
            return View();
        }

        // POST: /Teacher/Create
        [HttpPost]
        public ActionResult Create(string TeacherFname, string TeacherLname)
        {

            Teacher NewTeacher = new Teacher();
            NewTeacher.TeacherFname = TeacherFname;
            NewTeacher.TeacherLname = TeacherLname;

            TeacherDataController controller = new TeacherDataController();
            controller.AddTeacher(NewTeacher);

            Debug.WriteLine("i have accessed the create method");

            return RedirectToAction("List");
        }

        // GET: /Teacher/Update/{id}
        public ActionResult Update(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher SelectedTeacher = controller.FindTeacher(id);
            return View(SelectedTeacher);
        }

        //POST : /Teacher/Update/{id}

        [HttpPost]
        public ActionResult Update(int id, string TeacherFname, string TeacherLname)
        {
            Teacher TeacherInfo = new Teacher();
            TeacherInfo.TeacherFname = TeacherFname;
            TeacherInfo.TeacherLname = TeacherLname;

            TeacherDataController controller = new TeacherDataController();
            controller.UpdateTeacher(id, TeacherInfo);

            return RedirectToAction("show/" + id);
        }
    }
}