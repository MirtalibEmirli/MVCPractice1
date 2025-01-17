using Microsoft.AspNetCore.Mvc.Rendering;
using MVcPractice1.Entities;
using System.Collections.Generic;

namespace MVcPractice1.Models
{
    public class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }

        public List<SelectListItem> Cities { get; set; }
    }
}
