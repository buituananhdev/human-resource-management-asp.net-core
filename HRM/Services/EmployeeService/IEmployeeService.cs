using HRM.Models;

namespace HRM.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployees();
        Task<Employee?> GetSingleEmployee(string id);
        Task<List<Employee>> AddEmployee(Employee employee);
        Task<List<Employee>?> UpdateEmployee(string id, Employee request);
        Task<List<Employee>?> DeleteEmployee(string id);
    }
}
