using HRM.Data;
using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {

        private static List<Employee> Employees = new List<Employee>();

        private readonly DataContext _context;

        public EmployeeService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return Employees;
        }

        public async Task<List<Employee>?> DeleteEmployee(string id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if(employee is null)
            {
                return null;
            }
            _context.Remove(employee);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }

        public async Task<List<Employee>> GetAllEmployees()
        {
            var employees = await _context.Employees.ToListAsync();
            return employees;
        }

        public async Task<Employee> GetSingleEmployee(string id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee is null)
            {
                return null;
            }
            return employee;
        }

        public async Task<List<Employee>> UpdateEmployee(string id, Employee request)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee is null)
            {
                return null;
            }
            employee.employee_name = request.employee_name;
            employee.address = request.address;
            employee.phone_number = request.phone_number;
            employee.base_salary = request.base_salary;
            employee.coefficients_salary = employee.coefficients_salary;
            employee.position = employee.position;
            employee.department_id = employee.department_id;

            await _context.SaveChangesAsync();
            return Employees;
        }
    }
}
