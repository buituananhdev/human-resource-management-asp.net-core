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

        public async Task<Department?> GetSingleDepartment(string id)
        {
            var departments = await _context.Departments.FindAsync(id);
            if(departments is null)
            {
                return null;
            }
            return departments;
        }

        public async Task<List<Department>> AddDepartment(Department department)
        {
            _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            return await _context.Departments.ToListAsync() ;
        }

        public async Task<List<Department>?> DeleteDepartment(string id)
        {
            
            var department = await _context.Departments.FindAsync(id);
            if(department is null)
            {
                return null;
            }
            _context.Remove(department);
            await _context.SaveChangesAsync();
            return await _context.Departments.ToListAsync();
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            var departments = await _context.Departments.ToListAsync();
            return departments;
        }

        public async Task<List<Department>?> UpdateDepartment(string id, Department request)
        {
            var department = await _context.Departments.FindAsync(id);
            if(department is null)
            {
                return null;
            }
            department.department_name = request.department_name;
            await _context.SaveChangesAsync();
            return await _context.Departments.ToListAsync();
        }
    }
}
