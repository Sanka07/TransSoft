using Sashti.Model.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sashti.Service.Employee
{
	public interface IEmployeeService
	{
		Task<List<EmployeeResponse>> GetEmployees();
		Task<List<JobTitleResponse>> GetJobTitle();
		Task<List<DepartmentResponse>> GetDepartment();
	}
}
