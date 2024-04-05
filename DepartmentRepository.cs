using ProjectEmployeeLab3.Models;

namespace ProjectEmployeeLab3
{
    public class DepartmentRepository
    {
        public List<DepartmentModel> ListDepartment { get; set; }
        public DepartmentRepository()
        {
            ListDepartment = new List<DepartmentModel>();
            ListDepartment.Add(new DepartmentModel() { DeptId = 101, DepartmentName = "computer science" });
            ListDepartment.Add(new DepartmentModel() { DeptId = 102, DepartmentName = "physical science" });
        }
        public List<DepartmentModel> GetDepts()
        {
            return ListDepartment;
        }
        public DepartmentModel GetDeptById(int id)
        {
            return ListDepartment.Find(dept => dept.DeptId == id);
        }
    }
}
