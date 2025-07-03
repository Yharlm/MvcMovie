using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    // Before controler becomes the namespace for the views
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return base.View();
        }

        public IActionResult Welcome (string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
