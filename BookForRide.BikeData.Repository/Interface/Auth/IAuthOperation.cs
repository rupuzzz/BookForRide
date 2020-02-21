using BookForRide.Entity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.BikeData.Repository.Interface.Auth
{
    public interface IAuthOperation
    {
        Task<string> Register(UserRegisterModel model);
        string Token(LoginModel model);

        bool IsLogin(string str);
    }
}
