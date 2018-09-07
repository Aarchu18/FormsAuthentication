using FormsAuthentication.Models;
using FormsAuthentication.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FormsAuthentication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            var result = CredentialData.GetAllUsers()
                        .Where(x => x.UserName == model.UserName && x.Password == model.Password)?
                        .FirstOrDefault();

            if (result != null)
            {
                return RedirectToAction("Dashboard", result);
            }
            return RedirectToAction("LoginDenied");
        }

        public IActionResult Dashboard(UserModel model)
        {
            return View(model);
        }
        public IActionResult LoginDenied()
        {
            ViewData["Message"] = "Login Denied, Please try again.";

            return View();
        }
    }
}