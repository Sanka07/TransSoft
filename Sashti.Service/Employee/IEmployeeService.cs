using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sashti.Service.Employee
{
	public interface IEmployeeService
	{
		Task<List<Model.Employee.EmployeeResponse>> GetEmployees();
	}
}
