using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
