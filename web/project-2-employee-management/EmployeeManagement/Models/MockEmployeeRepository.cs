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
                new Employee() {Id = 1, Name = "Mary", Department = "HR", Email = "mary@basic.com"},
                new Employee() {Id = 2, Name = "Ed", Department = "IT", Email = "ed@basic.com"},
                new Employee() {Id = 3, Name = "Sue", Department = "IT", Email = "sue@basic.com"}
            };
        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);        }
    }
}
