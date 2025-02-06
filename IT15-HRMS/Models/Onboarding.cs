namespace IT15_HRMS.Models
{
    public class Onboarding
    {
        public int OnboardingId { get; set; }  // Primary Key
        public int EmployeeId { get; set; }  // Foreign Key to Employee
        public Employee Employee { get; set; } // Navigation property

        public DateTime OnboardingStartDate { get; set; }
        public DateTime? OnboardingCompletionDate { get; set; }  // Nullable in case onboarding is incomplete
        public string Status { get; set; }  // e.g., Pending, Completed, In Progress
        public string OnboardingChecklist { get; set; } // JSON or text containing tasks to be completed
    }
}
