using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
