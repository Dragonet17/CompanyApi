using Microsoft.AspNetCore.Mvc;

namespace FL.API.Controllers
{
    public class EmployeeController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return
            View();
        }
    }
}