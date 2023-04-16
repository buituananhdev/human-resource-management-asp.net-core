using HRM.Services.EmployeeService;
using Microsoft.AspNetCore.Mvc;

namespace HRM.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _EmployeeService;

        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }

        public async Task<IActionResult> GetAllEmployees(string searchValue = "", string department_id = "")
        {
            var employees = await _EmployeeService.GetAllEmployees();
            if(!string.IsNullOrEmpty(department_id))
            {
                employees = employees.Where(e => e.department_id == department_id).ToList();
            }
            if(string.IsNullOrEmpty(searchValue))
            {
                employees = employees.Where(e =>
                    e.employee_name.ToLower().Contains(searchValue.ToLower()) ||
                    e.address.ToLower().Contains(searchValue.ToLower()) ||
                    e.phone_number.ToLower().Contains(searchValue.ToLower()) ||
                    e.position.ToLower().Contains(searchValue.ToLower())).ToList();
            }
            return View(employees);
        }

        public async Task<IActionResult> GetSingleEmployee(string id)
        {
            var result = await _EmployeeService.GetSingleEmployee(id);
            return View(result);
        }

        public async Task<IActionResult> AddEmployee(Employee request)
        {
            request.employee_id = Guid.NewGuid().ToString();
            if (!string.IsNullOrEmpty(request.employee_name))
            {
                await _EmployeeService.AddEmployee(request);
                RedirectToAction("Index");
                return View(request);
            }
            return View();
        }
        public async Task<IActionResult> DeleteEmployee(string id)
        {
            var result = await _EmployeeService.DeleteEmployee(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateEmployee(string id, Employee request)
        {
            var result = await _EmployeeService.UpdateEmployee(id, request);
            return View(request);
        }

        public async Task<IActionResult> Index()
        {
            return await GetAllEmployees();
        }
    }
}
