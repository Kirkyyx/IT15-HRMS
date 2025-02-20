﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IT15_HRMS.Models
{
    public class PTO
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
        public DateTime StartDate { get; set; }  // Start date of leave

        [Required]
        public DateTime EndDate { get; set; }  // End date of leave

        [Required]
        public int DaysRequested { get; set; }  // Number of leave days requested

        [Required]
        [MaxLength(20)]
        public string Status { get; set; }  // Pending, Approved, Rejected

        public string? Reason { get; set; }  // Optional reason for leave

        [Required]
        public DateTime RequestDate { get; set; }  // Date when leave was requested
    }
}
