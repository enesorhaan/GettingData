﻿using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class TeacherController : Controller
    {
        List<Branch> branches = new List<Branch>()
        {
            new Branch {ID=1, BranchName = "Math"},
            new Branch {ID=2, BranchName = "Literature"},
            new Branch {ID=3, BranchName = "Physics"},
        };
        public IActionResult AddTeacher()
        {
            ViewBag.Branches = branches;
            Teacher teacher = new Teacher();
            teacher.FirstName = "Enes";
            teacher.LastName = "Orhan";
            teacher.BranchID = 3;   
            return View(teacher);
        }

        [HttpPost]
        public IActionResult AddTeacher(Teacher teacher)
        {
            ViewBag.Branches = branches;
            return View();
        }

        public IActionResult AddTeacherUsingTuple()
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Enes";
            teacher.LastName = "Orhan";
            teacher.BranchID = 3;
            (List<Branch>, Teacher, Student) tuple = (branches,teacher,new Student());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult AddTeacherUsingTuple([Bind(Prefix ="Item2")] Teacher teacher, [Bind(Prefix ="Item3")] Student student)
        {
            return RedirectToAction("AddTeacherUsingTuple");
        }
    }
}
