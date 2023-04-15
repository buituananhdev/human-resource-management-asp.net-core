namespace HRM.Services.UserService
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
        Task<List<User>> AddUser(User user);
        Task<List<User>?> UpdateUser(string id, User request);
        Task<List<User>?> DeleteUser(string id);
        Task<bool> Login (string username, string password);
    }
}
