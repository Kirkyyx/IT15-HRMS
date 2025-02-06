namespace IT15_HRMS.Models
{
    public class Payroll
    {
        public int PayrollId { get; set; }  // Primary Key
        public int EmployeeId { get; set; }  // Foreign Key to Employee
        public Employee Employee { get; set; } // Navigation property

        public DateTime PayPeriodStartDate { get; set; }
        public DateTime PayPeriodEndDate { get; set; }
        public double BasicSalary { get; set; }
        public double Bonus { get; set; }
        public double Deductions { get; set; }
        public double NetPay { get; set; } // Calculated: BasicSalary + Bonus - Deductions
        public DateTime DatePaid { get; set; }
    }
}

