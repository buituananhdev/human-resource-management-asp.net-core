using Microsoft.EntityFrameworkCore;

namespace HRM.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private static List<Department> Departments = new List<Department>();
        private readonly DataContext _context;

        public DepartmentService(DataContext context)
        {
            _context = context;
        }
        public Task<List<Department>> AddDepartment(Department department)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>?> DeleteDepartment(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            var departments = await _context.Departments.ToListAsync();
            return departments;
        }

        public Task<List<Department>?> UpdateDepartment(string id, Department request)
        {
            throw new NotImplementedException();
        }
    }
}
