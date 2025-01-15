using MVcPractice1.Entities;
using System.Collections.Generic;

namespace MVcPractice1.Models
{
    public class EmployeViewModel
    {
       public List<Employee> Employees { get; set; }

        public List<string> Cities { get; set; }

    }
}
