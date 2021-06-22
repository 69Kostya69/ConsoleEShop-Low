using EShop.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Data.Interfaces
{
    public interface IUserRepository
    {
        User GetUserByEmailAndPassword(string email, string password);
        void AddUser(User model);
        List<User> GetAll();
        User GetById(int id);
    }
}
