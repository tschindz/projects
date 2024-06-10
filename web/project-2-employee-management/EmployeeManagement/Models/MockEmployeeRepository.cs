
namespace EmployeeManagement.Models
{
    //model class that knows how to retrieve employee data
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@basic.com"},
                new Employee() {Id = 2, Name = "Ed", Department = Dept.IT, Email = "ed@basic.com"},
                new Employee() {Id = 3, Name = "Sue", Department = Dept.IT, Email = "sue@basic.com"}
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);        }
    }
}
