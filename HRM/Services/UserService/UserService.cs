using Microsoft.AspNetCore.Identity;

namespace HRM.Services.UserService
{
    public class UserService : IUserService
    {
        private static List<User> Users = new List<User>();

        private readonly DataContext _context;

        public async Task<List<User>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Users;
        }

        public async Task<List<User>?> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if(user is null)
            {
                return null;
            }
            _context.Remove(user);
            await _context.SaveChangesAsync();
            return Users;
        }

        public Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>?> UpdateUser(string id, User request)
        {
            throw new NotImplementedException();
        }
    }
}
