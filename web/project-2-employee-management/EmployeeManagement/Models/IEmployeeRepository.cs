namespace EmployeeManagement.Models
{
    //use interface so I can use dependency injection for flexibility and maintability later
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int Id);
        IEnumerable<Employee> GetAllEmployees();
    }
}
