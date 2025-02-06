namespace IT15_HRMS.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }  // Primary Key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PositionApplied { get; set; }  // Position being applied for
        public DateTime DateApplied { get; set; }
        public string ApplicationStatus { get; set; } // e.g., Pending, Accepted, Rejected

        // Relationship: An applicant can be converted to an employee once accepted
        public int? EmployeeId { get; set; }  // Nullable, in case applicant is not hired
        public Employee Employee { get; set; } // Navigation property
    }
}

