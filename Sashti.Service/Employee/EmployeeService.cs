using Sashti.Repository.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sashti.Service.Employee
{
	public class EmployeeService : IEmployeeService
	{
		private IEmployeeMaster _employeeMaster;

		public EmployeeService(IEmployeeMaster employeeMaster)
		{
			_employeeMaster = employeeMaster;
		}

		async Task<List<Model.Employee.EmployeeResponse>> IEmployeeService.GetEmployees()
		{
			return await _employeeMaster.GetEmployees();
		}
	}
}
