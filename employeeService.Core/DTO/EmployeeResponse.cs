namespace employeeService.Core.DTO
{
    /// <summary>
    /// Created By: Aravind Vagari
    /// Created On: 01/12/2025
    /// Represent the Employee Response DTO
    /// </summary>
    public class EmployeeResponse
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public decimal Salary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
