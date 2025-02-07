using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT15_HRMS.Models
{
    public class EmployeeLogin
    {
        [Key]
        public int EmployeeLoginId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; }

        public Employee Employee { get; set; }
    }
}
