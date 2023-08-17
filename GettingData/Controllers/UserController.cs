using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
        {
            new User() {UserName = "enesorhan", Password = "12345", Age = 24 },
            new User() {UserName = "muratorhaan", Password = "1965", Age = 58 },
            new User() {UserName = "srhnorhn", Password = "1988", Age = 35 },
            new User() {UserName = "frknorhan", Password = "1999", Age = 24 },
        };
        public IActionResult GetUsers()
        {
            return View(users);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            users.Add(user);

            return View("GetUsers",users);
        }
    }
}
