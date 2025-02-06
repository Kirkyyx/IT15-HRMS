using IT15_HRMS.Models;
using IT15_HRMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace IT15_HRMS.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Employee employee, string plainPassword)
        {
            if (ModelState.IsValid)
            {
                // Register the employee using the service
                _employeeService.RegisterEmployee(employee, plainPassword);

                // Redirect to a success page or the login page
                return RedirectToAction("Login", "Account");
            }

            // Return to the registration view with validation errors
            return View(employee);
        }
    }
}
