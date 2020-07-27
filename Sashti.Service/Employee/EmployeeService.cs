using Sashti.Repository.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Sashti.Model.Employee;

namespace Sashti.Service.Employee
{
	public class EmployeeService : IEmployeeService
	{
		private IEmployeeMaster _employeeMaster;

		public EmployeeService(IEmployeeMaster employeeMaster)
		{
			_employeeMaster = employeeMaster;
		}

		async Task<List<EmployeeResponse>> IEmployeeService.GetEmployees()
		{
			return await _employeeMaster.GetEmployees();
		}

		async Task<List<JobTitleResponse>> IEmployeeService.GetJobTitle()
		{
			return await _employeeMaster.GetJobTitle();
		}

		async Task<List<DepartmentResponse>> IEmployeeService.GetDepartment()
		{
			return await _employeeMaster.GetDepartment();
		}
	}
}
