using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sashti.Model.Employee;
using Sashti.Service.Employee;

namespace sashti.Controllers
{
	public class AddEmployeeController : Controller
	{
		private IEmployeeService _employeeservice;

		public AddEmployeeController(IEmployeeService employeeService)
		{
			_employeeservice = employeeService;
		}

		public async Task<IActionResult> IndexAsync()
		{
			JobtitleandDepartment response = new JobtitleandDepartment();

			response.JobTitle = await _employeeservice.GetJobTitle();
			response.Departments = await _employeeservice.GetDepartment();



			return View("~/Views/AddEmployee/Index.cshtml", response);
		}
	}
}
