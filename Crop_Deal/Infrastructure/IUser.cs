using Crop_Deal.Models;

namespace Crop_Deal.Infrastructure
{
    public interface IUser
    {
        // Add all the methods related to the user.
        Task<List<User>> GetAllUsers();
        
        Task<User> UserInsert(User user);

        Task<User> UserUpdate(User user);

        Task<User> UserDelete(User user);
    }
}
