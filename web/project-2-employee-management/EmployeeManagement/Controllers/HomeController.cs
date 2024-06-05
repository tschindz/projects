using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

//Handles and processes incoming requests and outgoing responses, action methods
namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        //constructor injection: use constructor for service (IEmployeeRepository) dependency injection
        public HomeController(IEmployeeRepository employeeRepository)
        {
            //use new instance so it can be changed later. 
            _employeeRepository = new MockEmployeeRepository();
        }

        public ViewResult Index()
        {
            ViewBag.PageTitle = "Home";
            //return _employeeRepository.GetEmployee(1).Name;
            return View();
        }

        //grab specific details and send to browser
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.Employee = model;
            ViewBag.PageTitle = "Employee Details";
            return View();
        }
    }
}
