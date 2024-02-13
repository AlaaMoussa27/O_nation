using final_project.Models;
using System.Linq;

namespace Registration.Models
{
    public class UserRepository : IUserRepository
    {
        //public User GetProfileById(int userId)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void UpdateProfile(User profile)
        //{
        //    throw new System.NotImplementedException();
        //}
        private readonly O_NATIONContext _context;

        public UserRepository(O_NATIONContext context)
        {
            _context = context;
        }

        public User GetProfileById(int userId)
        {
            return _context.Users.FirstOrDefault(p => p.Id == userId);
        }

        public void UpdateProfile(User profile)
        {
            _context.Users.Update(profile);
            _context.SaveChanges();
        }
    }
}

