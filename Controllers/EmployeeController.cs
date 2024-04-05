using Microsoft.AspNetCore.Mvc;
using ProjectEmployeeLab3.Models;

namespace ProjectEmployeeLab3.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            EmployeeRepository emp_repos = new EmployeeRepository();
            DepartmentRepository department_repos = new DepartmentRepository();
            List<EmployeeModel> employees = emp_repos.GetEmployees();
            foreach (var employee in employees)
            {
                employee.Department = department_repos.GetDeptById(employee.DId);
            }
            return View(employees);

        }
    }
}
