using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralProject.Business.Abstract;
using GeneralProject.Business.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace GeneralProject.UIWEB.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _IEmployeeService;
        private readonly IEmployeeAddressService _IEmployeeAddressService;

        public EmployeeController(IEmployeeService IEmployeeService, IEmployeeAddressService IEmployeeAddressService)
        {
            _IEmployeeService = IEmployeeService;
            _IEmployeeAddressService = IEmployeeAddressService;
        }

        public IActionResult Index()
        {
            var Employes = _IEmployeeService.GetAll();
            var EmployeAddress = _IEmployeeAddressService.GetAll(); 

            return View();
        }
    }
}
