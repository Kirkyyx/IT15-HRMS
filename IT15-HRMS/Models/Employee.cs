namespace IT15_HRMS.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }  // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }

        // Navigation properties for related data
        public ICollection<Attendance> Attendances { get; set; }  // One-to-many relationship with Attendance
        public ICollection<Payroll> Payrolls { get; set; }  // One-to-many relationship with Payroll
        public Onboarding Onboarding { get; set; }  // One-to-one relationship with Onboarding
        public Applicant Applicant { get; set; }  // One-to-one relationship with Applicant (if needed)
    }
}


