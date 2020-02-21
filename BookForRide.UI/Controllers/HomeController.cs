using BookForRide.BikeData.Repository.Concrete.Auth;
using BookForRide.Entity.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BookForRide.UI.Controllers
{
    public class HomeController : Controller
    {
        public async Task< ActionResult> Index()
        {
            AuthOperation api = new AuthOperation();
            await api.Register(new UserRegisterModel() { Email = "kashyap@gmail.com", ConfirmPassword = "Login@123", Password = "Login@123" });
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}