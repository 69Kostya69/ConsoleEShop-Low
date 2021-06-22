using EShop.Data.Entities;
using System.Linq;

namespace EShop.Data.Interfaces
{
    public interface IUserRepository
    {
        User LogIn(string email, string password);
        void Register(User model);
        IQueryable<User> GetAll();
    }
}
