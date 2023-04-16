using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRM.Models;
using HRM.Services;
using HRM.Services.DepartmentService;
using Azure.Core;

namespace HRM.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        public async Task<IActionResult> GetAllDepartments(string searchValue = "")
        {
            var departments = await _departmentService.GetAllDepartments();
            if (!string.IsNullOrEmpty(searchValue))
            {
                departments = departments.Where(d => d.department_name.ToLower().Contains(searchValue.ToLower())).ToList();
            }
            return View(departments);
        }

        public async Task<IActionResult> GetSingleDepartment(string id)
        {
            var result = await _departmentService.GetSingleDepartment(id);
            return View(result);
        }

        public async Task<IActionResult> AddDepartment(Department request)
        {
            request.department_id = Guid.NewGuid().ToString();
            if (!string.IsNullOrEmpty(request.department_name))
            {
                await _departmentService.AddDepartment(request);
                RedirectToAction("Index");
                return View(request);
            }
            return View();
        }
        public async Task<IActionResult> DeleteDepartment(string id)
        {
            var result = await _departmentService.DeleteDepartment(id);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateDepartment(string id, Department request)
        {
            var result = await _departmentService.UpdateDepartment(id, request);
            return View(request);
        }

        public async Task<IActionResult> Index()
        {
            return await GetAllDepartments();
        }
    }
}
