using Sashti.Model.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sashti.Repository.Employee
{
	public interface IEmployeeMaster
	{
		Task<string> SaveEmployee(EmployeeRequest request);
	}
}
