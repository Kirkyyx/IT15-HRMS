using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT15_HRMS.Models
{
    public class PTO
    {
        [Key]
        public int PTOId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [MaxLength(100)]
        public string Reason { get; set; }

        public Employee Employee { get; set; }
    }
}
