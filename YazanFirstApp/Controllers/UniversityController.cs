using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YazanFirstApp.Models;

namespace YazanFirstApp.Controllers
{
    public class UniversityController : Controller
    {

       static List<Student> students = new List<Student>() {
        new Student{Id=1,Name="Rami",Age=20,City="amman",RegisterDate=DateTime.Now},
        new Student{Id=2,Name="hiba",Age=33,City="karak",RegisterDate=DateTime.Now},
new Student{Id=3,Name="sami",Age=44,City="amman",RegisterDate=DateTime.Now},
new Student{Id=4,Name="Rula",Age=18,City="aqaba",RegisterDate=DateTime.Now},


        };

        public IActionResult AllStudents()
        {
            return View(students);
        }
        public IActionResult AboutStudent()
        {
            return View();
        }

        public IActionResult Vision()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateStudent(Student obj)
        {
            obj.RegisterDate = DateTime.Now;
            obj.isActive = true;
            students.Add(obj);
            return RedirectToAction("AllStudents");
        }
        public IActionResult DeleteStudent(int id)
        {
            var x = (from stu in students
                    where stu.Id == id
                    select stu).SingleOrDefault();
            students.Remove(x);
            return RedirectToAction("AllStudents");
        }
    }
}
