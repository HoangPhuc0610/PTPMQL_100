using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is the Welcome action method 2...";
        }
    }
}
