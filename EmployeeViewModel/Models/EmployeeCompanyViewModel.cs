using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeViewModel.Models
{
    public class EmployeeCompanyViewModel
    {
        public List<Company> Companies { get; set; }  

        public List<Employee> Employees { get; set; }
    }
}