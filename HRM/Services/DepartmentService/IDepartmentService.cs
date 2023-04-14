namespace HRM.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllDepartments();
        Task<Department?> GetSingleDepartment(string id);
        Task<List<Department>> AddDepartment(Department department);
        Task<List<Department>?> UpdateDepartment(string id, Department request);
        Task<List<Department>?> DeleteDepartment(string id);
    }
}
