using EnterpriseEMS.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseEMS.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            if (User.IsInRole("Admin") ||User.IsInRole("HR"))
            {
                ViewBag.TotalAttendance =_context.Attendances.Count();

                ViewBag.TotalEmployee = _context.Employees.Count();

                ViewBag.TotalLeave =_context.LeaveRequests.Count();

                ViewBag.ActiveEmployee =_context.Employees.Count(x => x.IsActive);

                return View("AdminDashboard");
            }

            return View("EmployeeDashboard");
        }
    }
}
