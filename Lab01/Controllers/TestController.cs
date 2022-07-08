using Microsoft.AspNetCore.Mvc;

namespace Lab01.Controllers
{
    public class TestController : Controller
    {
        
        public IActionResult TestIndex()
        {
            return View();
        }
    }
}
