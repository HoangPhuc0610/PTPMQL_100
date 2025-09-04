using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method 1...";
        }
    }
}
