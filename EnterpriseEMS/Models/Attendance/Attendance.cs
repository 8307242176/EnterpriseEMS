/*using EmployeeModel = EnterpriseEMS.Models.Employee.Employee;*/
using EnterpriseEMS.Models.Employee;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseEMS.Models.Attendance
{
    public class Attendance
    {
        public int Id { get; set; }
        [Required]
        public int EmployeeId { get; set; }

        public EnterpriseEMS.Models.Employee.Employee? Employee { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? CheckInTime { get; set; }
        public TimeSpan? CheckOutTime {  get; set; }
        public string? Status {  get; set; }

    }
}
