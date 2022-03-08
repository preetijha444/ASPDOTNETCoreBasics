using ASPDOTNETCoreBasics.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDOTNETCoreBasics.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult UserLogin(LoginViewModel model)
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(UserViewModel model)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }

    }
}

        //[HttpPost]
        //public IActionResult Login(string Email, string Password)
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Login(IFormCollection form)
        //{
        //    string Email = form["email"];
        //    string Password = form["password"];

        //    return View();
        //}
        