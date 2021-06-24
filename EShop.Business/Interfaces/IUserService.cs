using EShop.Business.Models;

namespace EShop.Business.Interfaces
{
    public interface IUserService
    {
        void RegisterUser(RegisterModel model);
        bool LoginUser(LoginModel model);
    }
}
