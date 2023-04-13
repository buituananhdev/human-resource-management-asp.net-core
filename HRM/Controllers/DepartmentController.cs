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

        public async Task<IActionResult> GetAllDepartments()
        {
            List<Department> departments = await _departmentService.GetAllDepartments();
            return View(departments);
        }

        public async Task<IActionResult> Index()
        {
            return await GetAllDepartments();
        }
    }
}
