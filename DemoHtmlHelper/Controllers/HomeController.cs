using DemoHtmlHelper.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoHtmlHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        /*[HttpPost]
        public IActionResult Login(string username , string password)
        {
            string str = username+":" + password;
            return Content(str);
        }*/
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            string username = model.Username;
            string password = model.Password;
            string str = username + ":" + password;
            return Content(str);
        }
        public IActionResult Emp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Emp(EmployeeModel model)
        {
            string Name = model.Name;
            string Email = model.Email;
            string birthday = model.DateofBirth.ToString();
            string birthTime = model.BirthTime.ToString();
            string str = Name + " " + Email + " " + birthday + " " + birthTime;
            return Content(str);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}