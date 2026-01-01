namespace employeeService.Core.Entities
{
    /// <summary>
    /// Created By: Aravind Vagari
    /// Created On: 01/12/2025
    /// Represents the Employee Entity.
    /// </summary>
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
