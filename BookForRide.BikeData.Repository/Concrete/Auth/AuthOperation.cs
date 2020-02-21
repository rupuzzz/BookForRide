using BookForRide.BikeData.Repository.Concrete.Utility;
using BookForRide.BikeData.Repository.Interface.Auth;
using BookForRide.Entity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookForRide.BikeData.Repository.Concrete.Auth
{
    public class AuthOperation : IAuthOperation
    {
        public AuthOperation()
        {
            
        }
        public bool IsLogin(string str)
        {
            return false;
        }

        public async Task<string> Register(UserRegisterModel model)
        {
            try
            {
                await ApiProxy<UserRegisterModel>.Post(model, "Account/Register");
            }
            catch
            {

            }
            return "check";
        }

        public string Token(LoginModel model)
        {
            throw new NotImplementedException();
        }
    }
}
