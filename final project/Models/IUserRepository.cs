using final_project.Models;

namespace Registration.Models
{
    public interface IUserRepository
    {
        User GetProfileById(int userId);
        void UpdateProfile(User profile);
    }

}
