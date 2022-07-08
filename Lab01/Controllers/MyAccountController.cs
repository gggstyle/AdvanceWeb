using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class MyAccountController : Controller
    {
        public IActionResult MyData()
        {
            return View();
        }
    }
}
