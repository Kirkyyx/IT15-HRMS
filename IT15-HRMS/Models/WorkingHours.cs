using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT15_HRMS.Models
{
    public class WorkingHours
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }  // Foreign Key linking to Employee
        public Employee Employees { get; set; }  // Navigation property

        [Required]
        public DateTime WorkDate { get; set; }  // The date of the work shift

        [Required]
        public TimeSpan StartTime { get; set; }  // Shift start time

        [Required]
        public TimeSpan EndTime { get; set; }  // Shift end time

        [Required]
        public TimeSpan TotalHours { get; set; }  // Total worked hours
    }
}
