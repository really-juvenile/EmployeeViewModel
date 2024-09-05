using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EmployeeViewModel.Models;



namespace EmployeeViewModel.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            // Create sample Employee data
            var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Allen Bro", Salary = 100000, Designation = "Manager" },
            new Employee { Id = 2, Name = "Mary Sis", Salary = 90000, Designation = "Developer" }
        };

            // Create sample Company data
            var companies = new List<Company>
        {
            new Company { Id = 1, Name = "Deloitte", Location = "New York" },
            new Company { Id = 2, Name = "KPMG", Location = "Cali" }
        };

            // Create the ViewModel
            var viewModel = new EmployeeCompanyViewModel()
            {
                Employees = employees,
                Companies = companies
            };

            // Pass the ViewModel to the view
            return View(viewModel);
        }
    }

}