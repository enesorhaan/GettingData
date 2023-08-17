using GettingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(Product product,string name)
        {
            return "App is running..";
        }

        // home/usequerystring?name=enes&surname=orhan
        public string UseQueryString(string name, string surname)
        {
            return "App is running..";
        }

    }
}
