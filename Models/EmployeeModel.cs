namespace ProjectEmployeeLab3.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public int DId { get; set; }
        public DepartmentModel Department { get; set; }
    }
}
