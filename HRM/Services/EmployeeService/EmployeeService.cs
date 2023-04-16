using HRM.Data;
using HRM.Models;

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

        public Task<List<Employee>> AddEmployee(Employee organization)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>?> DeleteEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetSingleEmployee(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>?> UpdateEmployee(string id, Employee request)
        {
            throw new NotImplementedException();
        }
    }
}
