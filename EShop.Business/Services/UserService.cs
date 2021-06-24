using AutoMapper;
using EShop.Business.Extensions;
using EShop.Business.Interfaces;
using EShop.Business.Models;
using EShop.Business.Validation;
using EShop.Data.Entities;
using EShop.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _data;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork data, IMapper mapper)
        {
            this._data = data;
            this._mapper = mapper;
        }

        private RegisterModel FindUser(string email, string password) =>
            _mapper.Map<RegisterModel>(_data.Users.GetUserByEmailAndPassword(email, password));

        public bool LoginUser(LoginModel model)
        {
            var user = FindUser(model.Email, model.Password);
            if (user == null)
                throw new AuthorizeException("Unauthorized");
            else
                return true;
        }

        public void RegisterUser(RegisterModel model)
        {
            if (model.IsModelInvalid())
                throw new ModelException("uncorrect user model");
            if (model.Email.IsEmailExist(_data))
                throw new UnuniqueException("this email already exist");

            var user = _mapper.Map<User>(model);
            user.Role = "User";
            _data.Users.AddUser(user);
        }
    }
}

