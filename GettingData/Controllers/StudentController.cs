using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class StudentController : Controller
    {
        List<Student> students = new List<Student>()
        {
            new Student() {FirstName = "Enes", LastName = "Orhan"},
            new Student() {FirstName = "Murat", LastName = "Orhan"},
            new Student() {FirstName = "Furkan", LastName = "Orhan"},
            new Student() {FirstName = "Serhan", LastName = "Orhan"},
        };
        public IActionResult GetStudentList()
        {
            return View(students);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            students.Add(student);

            return View("GetStudentList",students);
        }
    }
}
