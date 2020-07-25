using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sashti.Model.Employee;
using Sashti.Service.Employee;

namespace sashti.Controllers
{
	public class EmployeeController : Controller
	{
		private IEmployeeService _employeeservice;

		public EmployeeController(IEmployeeService employeeService)
		{
			_employeeservice = employeeService;
		}
		public async Task<IActionResult> IndexAsync()
		{
			List<EmployeeResponse> Response = new List<EmployeeResponse>();
			Response= await _employeeservice.GetEmployees();
			return View("~/Views/Employee/Index.cshtml", Response);
		}
	}
}
