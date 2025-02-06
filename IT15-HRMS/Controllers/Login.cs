using Microsoft.AspNetCore.Mvc;

namespace HRMS.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Login/Login
        public IActionResult Login()
        {
            return View("~/Views/Home/Login.cshtml");
        }


        // POST: /Login/Login
        [HttpPost]
        public IActionResult Login(string email, string password, bool rememberMe)
        {
            // Example authentication logic
            if (email == "admin" && password == "password")  // Replace with actual logic
            {
                // Redirect to home or dashboard page upon successful login
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // If login fails, show error message
                ViewBag.ErrorMessage = "Invalid email or password.";
                return View();  // Return the Login view again with the error message
            }
        }
    }
}


