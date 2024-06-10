using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
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
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        //grab specific details and send to browser
        public ViewResult Details(int? id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                employee = _employeeRepository.GetEmployee(id ?? 1),
                PageTitle = "Employee Details"
            };
            
            return View(homeDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
        }
    }
}
