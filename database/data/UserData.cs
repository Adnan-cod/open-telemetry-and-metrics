using database.context;
using database.context.Models;

namespace database.data
{
    public class UserData : IUserData
    {
        private AuthDbContext _authDbContext;
        public UserData(AuthDbContext dbContext) 
        {
            _authDbContext = dbContext;
        }
        public Task<bool> CreateUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<User> ValidatePassword(string userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
