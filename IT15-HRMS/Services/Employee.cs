using IT15_HRMS.Models;
using Microsoft.AspNetCore.Identity;

namespace IT15_HRMS.Services
{
    public class EmployeeService
    {
        private readonly ApplicationDBContext _context;
        private readonly PasswordHasher<Employee> _passwordHasher;

        public EmployeeService(ApplicationDBContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<Employee>();
        }

        public void RegisterEmployee(Employee employee, string plainPassword)
        {
            // Hash the password before saving it
            employee.PasswordHash = _passwordHasher.HashPassword(employee, plainPassword);
            employee.DateCreated = DateTime.UtcNow;
            employee.IsActive = true;  // Default value
            employee.Role = "Employee";  // Default role

            // Save the employee to the database
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    }
}




