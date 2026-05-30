using System.ComponentModel.DataAnnotations;
using EnterpriseEMS.Models.Attendance;
using EnterpriseEMS.Models.Leave;
using Microsoft.AspNetCore.Identity;
namespace EnterpriseEMS.Models.Employee


{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee Code")]
        public int EmployeeCode { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Display(Name = "Joining Date")]
        public DateTime DateOfJoining { get; set; }
        public decimal Salary { get; set; }
        public string? Department { get; set; }
        public string? Designation { get; set; }

        [Display(Name = "Profile Image")]
        public string? ProfileImagePath { get; set; }
        public bool IsActive { get; set; }

        public ICollection<EnterpriseEMS.Models.Attendance.Attendance>? Attendances { get; set; }
        public ICollection<LeaveRequest>? LeaveRequests { get; set; }

    }
}
