using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace EmployeeViewModel.Models
{
    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        
    }
}