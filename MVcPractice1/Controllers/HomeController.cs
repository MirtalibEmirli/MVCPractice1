using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using MVcPractice1.Entities;
using MVcPractice1.Models;
using MVcPractice1.Views.Home;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVcPractice1.Controllers

{
    public class HomeController : Controller
    {  

        public string Index()
        { 
            return "salam from INdex";
        } 

        public IActionResult Index2()
        {
            return View();
        }
        public ViewResult Employee1 (){
            List<Employee> employees = new()
            {

                new Employee
                {
                    Id = 1,
                    Firstname = "Ali"
                ,
                    Lastname = "Aliyev",
                    CityId = 1
                },

                new Employee
                {
                    Id = 2,
                    Firstname = "Vaqif",
                    Lastname = "Abdulla",
                    CityId = 1
                }
                ,
                new Employee
                {
                    Id = 3,
                    Firstname = "Ahmad"
                ,
                    Lastname = "Adil",
                    CityId = 1
                }
            };
            return View(employees);


        }
        //public ViewResult Employee2()
        //{
        //    List<Employee> employees = new()
        //    {

        //        new Employee
        //        {
        //            Id = 1,
        //            Firstname = "Ali"
        //        ,
        //            Lastname = "Aliyev",
        //            CityId = 1
        //        },

        //        new Employee
        //        {
        //            Id = 2,
        //            Firstname = "Vaqif",
        //            Lastname = "Abdulla",
        //            CityId = 1
        //        }
        //        ,
        //        new Employee
        //        {
        //            Id = 3,
        //            Firstname = "Ahmad"
        //        ,
        //            Lastname = "Adil",
        //            CityId = 1
        //        }
        //    };
        //    return View(employees);


        //}
        public ViewResult Employee2()
        {
            List<Employee> employees = new()
            {

                new Employee
                {
                    Id = 1,
                    Firstname = "Ali"
                ,
                    Lastname = "Aliyev",
                    CityId = 1
                },

                new Employee
                {
                    Id = 2,
                    Firstname = "Vaqif",
                    Lastname = "Abdulla",
                    CityId = 1
                }
                ,
                new Employee
                {
                    Id = 3,
                    Firstname = "Ahmad"
                ,
                    Lastname = "Adil",
                    CityId = 1
                }
            };
            List<string> cities = new() { "Baku", "Berlin", "Toronto" };
            var viewModel = new EmployeViewModel
            {
                Cities=cities,
                Employees= employees
            };
            return View(viewModel);


        }
        public IActionResult Index4()
        
        {
            return Ok();
        }

        public IActionResult Mirtalib()
        {
            return NotFound();
        }
        public IActionResult Index6()
        {
            return BadRequest();
        }
        public IActionResult Index7()
        {
            return Redirect("/home/index");
        }
        public IActionResult Index8()
        {
            return RedirectToAction("Employee1");
        }
        public IActionResult Index9()
        {
            var routeValue = new RouteValueDictionary(new {action="Employee1",controller="Home"});
            return
               RedirectToRoute(routeValue);
        }

        public IActionResult Index10()
        {
            List<Employee> employees = new()
            {

                new Employee
                {
                    Id = 1,
                    Firstname = "Ali"
                ,
                    Lastname = "Aliyev",
                    CityId = 1
                },

                new Employee
                {
                    Id = 2,
                    Firstname = "Vaqif",
                    Lastname = "Abdulla",
                    CityId = 1
                }
                ,
                new Employee
                {
                    Id = 3,
                    Firstname = "Ahmad"
                ,
                    Lastname = "Adil",
                    CityId = 1
                }
            };
            return Json(employees);
        }

        //rootparam
        public JsonResult Index11(int id = -1)
        {
            List<Employee> employees = new()
            {

                new Employee
                {
                    Id = 1,
                    Firstname = "Ali"
                ,
                    Lastname = "Aliyev",
                    CityId = 1
                },

                new Employee
                {
                    Id = 2,
                    Firstname = "Vaqif",
                    Lastname = "Abdulla",
                    CityId = 1
                }
                ,
                new Employee
                {
                    Id = 3,
                    Firstname = "Ahmad"
                ,
                    Lastname = "Adil",
                    CityId = 1
                }
            };
            if (id==-1)
            {
                return Json(employees);
            }
            else
            {
                var data = employees.FirstOrDefault(e=>e.Id==id);
                return Json(data);

            }

        }
        public IActionResult Index12(string key, int id = -1)
        {
            List<Employee> employees = new()
            {

                new Employee
                {
                    Id = 1,
                    Firstname = "Ali"
                ,
                    Lastname = "Aliyev",
                    CityId = 1
                },

                new Employee
                {
                    Id = 2,
                    Firstname = "Vaqif",
                    Lastname = "Abdulla",
                    CityId = 1
                }
                ,
                new Employee
                {
                    Id = 3,
                    Firstname = "Ahmad"
                ,
                    Lastname = "Adil",
                    CityId = 1
                }
            };
            if (id==-1)
            {
                var data = employees.Where(e => e.Firstname.Contains(key));
                return Json(data);
            }
            else
            {
                var data = employees.Where(e => e.Id == id || e.Firstname.Contains(key));
                return Json(data);
            }
        }
    }
}
