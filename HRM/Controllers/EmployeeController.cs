using HRM.Services.EmployeeService;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            var employees = await _employeeService.GetAllEmployees();
            return View(employees);
        }

        [HttpGet]
        public async Task<IActionResult> GetSingleEmployee(string id)
        {
            var result = await _employeeService.GetSingleEmployee(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee request)
        {
            request.employee_id = Guid.NewGuid().ToString();
            var result = await _employeeService.AddEmployee(request);
            return View(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            await _employeeService.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
