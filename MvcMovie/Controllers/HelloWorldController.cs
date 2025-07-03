using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    // Before controler becomes the namespace for the views
    public class HelloWorldController : Controller
    {
        public string Welcome(string a, int ID)
        {
            return HtmlEncoder.Default.Encode($"Hello {a}, Num is {ID}!");
        }
    }
}
