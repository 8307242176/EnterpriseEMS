using System.ComponentModel.DataAnnotations;

namespace EnterpriseEMS.Models.Leave
{
    public class LeaveRequest
    {
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string? LeaveType { get; set; }
        public string? Reason { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
