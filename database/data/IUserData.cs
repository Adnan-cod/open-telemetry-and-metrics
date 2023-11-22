using database.context.Models;

namespace database.data
{
    public interface IUserData
    {
        Task<bool> CreateUserAsync(User user);
        Task<User> FindUserByIdAsync(string userId);
        Task<User> ValidatePassword(string userId, string password);
    }
}
