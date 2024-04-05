using ProjectEmployeeLab3.Models;

namespace ProjectEmployeeLab3
{
    public class EmployeeRepository
    {
        public List<EmployeeModel> ListEmployees { get; set; }

        public EmployeeRepository()
        {
            ListEmployees = new List<EmployeeModel>();
            ListEmployees.Add(new EmployeeModel() { Id = 1, Name = "Success Pokhrel", Email = "success012@gmail.com", DId = 101 });
            ListEmployees.Add(new EmployeeModel() { Id = 2, Name = "Safal Pandey", Email = "safal54@gmail.com", DId = 102 });
            ListEmployees.Add(new EmployeeModel() { Id = 3, Name = "Saksham Adhikari", Email = "saksham78@gmail.com", DId = 102 });
        }

        public List<EmployeeModel> GetEmployees()
        {
            return ListEmployees;
        }

        public EmployeeModel GetEmployeeById(int id)
        {
            return ListEmployees.Find(emp => emp.Id == id);
        }

    }
}
