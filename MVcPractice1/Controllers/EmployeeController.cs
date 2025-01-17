using Microsoft.AspNetCore.Mvc;
using MVcPractice1.Models;
using MVcPractice1.Entities;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVcPractice1.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet] //httpword
        public IActionResult Add()
        {
            var vm = new EmployeeAddViewModel()
            {
                Employee = new Employee(),
                Cities = new  List<SelectListItem>
                {
                    new SelectListItem{Text="Baku",Value="10"},
                    new SelectListItem{Text="Batumi",Value="11"},
                    new SelectListItem{Text="Yevlax",Value="12"},
                    new SelectListItem{Text="Quba",Value="50"},
                }
            };
            return View(vm);
        }

        [HttpPost]
        public IActionResult Add(EmployeeAddViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/home/index");

            }
            return View(viewModel);
        }


    }
}
