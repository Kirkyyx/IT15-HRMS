using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT15_HRMS.Models
{
    public class PTOBalance
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }  // Foreign Key linking to Employee
        public Employee Employee { get; set; }  // Navigation property

        [Required]
        [MaxLength(50)]
        public string LeaveCategory { get; set; }  // PTO, Sick Leave, Bereavement, Maternity Leave

        [Required]
        public int AllocatedDays { get; set; }  // Total allocated leave days

        [Required]
        public int UsedDays { get; set; }  // Number of used leave days

        [NotMapped]  // This is calculated, not stored in DB
        public int RemainingDays => AllocatedDays - UsedDays;

        [Required]
        public DateTime LastUpdated { get; set; }  // Last time PTO balance was updated
    }
}
