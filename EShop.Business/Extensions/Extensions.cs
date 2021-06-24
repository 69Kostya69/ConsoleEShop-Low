using EShop.Business.Models;
using EShop.Data.Interfaces;
using System;
using System.Linq;

namespace EShop.Business.Extensions
{
    public static class Extensions
    {
        public static bool IsModelInvalid(this RegisterModel model)
        {
            if (string.IsNullOrEmpty(model.Name) ||
               string.IsNullOrEmpty(model.Surname) ||
               string.IsNullOrEmpty(model.Email) ||
               string.IsNullOrEmpty(model.Password) ||
               !char.IsUpper(model.Name[0]) ||
               !char.IsUpper(model.Surname[0]))
                return true;
            else
                return false;
        }

        public static bool IsEmailExist(this string email, IUnitOfWork context)
        {
            if (context.Users.GetAll().Select(x => x.Email).Contains(email))
                return true;
            else
                return false;
        }
    }
}
