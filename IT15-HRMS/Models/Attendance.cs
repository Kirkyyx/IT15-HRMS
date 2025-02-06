namespace IT15_HRMS.Models
{
    public class Attendance
    {
        public int AttendanceId { get; set; }  // Primary Key
        public int EmployeeId { get; set; }  // Foreign Key to Employee
        public Employee Employee { get; set; } // Navigation property

        public DateTime Date { get; set; }
        public TimeSpan EntryTime { get; set; }
        public TimeSpan ExitTime { get; set; }
        public double TotalHoursWorked { get; set; }  // Could be calculated or manually entered
    }
}
