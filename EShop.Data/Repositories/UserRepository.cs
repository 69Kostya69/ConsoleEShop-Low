using EShop.Data.Entities;
using EShop.Data.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EShop.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
       
        private IContext context;
        public UserRepository(IContext _context)
        {
            context = _context;
        }

        public User GetUserByEmailAndPassword(string email, string password) => context.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        public void AddUser(User model) => context.Users.Add(model);
        public List<User> GetAll() => context.Users;
        public User GetById(int id) => context.Users.Find(c => c.Id == id); 
    }
}

