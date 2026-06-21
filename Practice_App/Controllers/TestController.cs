using Microsoft.AspNetCore.Mvc;

namespace Practice_App
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyMethod(int num)
        {
            ViewData["nums"] = num;
            return View();
        }

    }
}