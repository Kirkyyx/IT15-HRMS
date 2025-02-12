using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT15_HRMS.Models
{
    public class PayrollStatus
    {
        [Key]
        public int Id { get; set; }  // Primary Key

        [ForeignKey("Payroll")]
        public int PayrollId { get; set; }  // Foreign Key linking to Payroll
        public Payroll Payroll { get; set; }  // Navigation property

        [Required]
        [MaxLength(50)]
        public string Status { get; set; }  // Status (e.g., Pending, Processed, Paid)

        [Required]
        public DateTime UpdatedAt { get; set; }  // Last status update timestamp
    }
}
