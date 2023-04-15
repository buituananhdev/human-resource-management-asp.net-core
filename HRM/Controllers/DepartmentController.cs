using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRM.Models;
using HRM.Services;
using HRM.Services.DepartmentService;

namespace HRM.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDepartments()
        {
            var departments = await _departmentService.GetAllDepartments();
            return View(departments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleDepartment(string id)
        {
            var result = await _departmentService.GetSingleDepartment(id);
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddDepartment(Department request)
        {
            request.department_id = Guid.NewGuid().ToString();
            await _departmentService.AddDepartment(request);
            return RedirectToAction("Index");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(string id)
        {
            await _departmentService.DeleteDepartment(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Index()
        {
            return await GetAllDepartments();
        }
    }
}
