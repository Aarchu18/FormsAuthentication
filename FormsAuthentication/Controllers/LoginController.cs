using FormsAuthentication.DAL;
using FormsAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FormsAuthentication.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        private DBOperation dBOperations = new DBOperation();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginModel loginModel)
        {
            List<LoginList> loginList = dBOperations.GetAllUser();
            LoginList result = loginList
                        .Where(x => x.UserName == loginModel.UserName && x.UserPassword == loginModel.Password)?
                        .FirstOrDefault();

            if (result != null)
            {
                return RedirectToAction("Dashboard", result);
            }
            return RedirectToAction("LoginDenied");
        }

        public IActionResult Dashboard(LoginList model)
        {
            if(model.UserName!=null)
            {
                return View(model);
            }
            return RedirectToAction("Index");
            
        }
        public IActionResult LoginDenied()
        {

            ViewData["Message"] = "Login Denied, Please try again.";

            return View();
        }
    }
}