using Sashti.Model.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace Sashti.Repository.Employee
{
	public class EmployeeMaster : IEmployeeMaster
	{
		async Task<string> IEmployeeMaster.SaveEmployee(EmployeeRequest Request)
		{
			string Response = string.Empty;

			try
			{
				var EmployeeParam = new DynamicParameters();
				EmployeeParam.Add("@FirstName", Request.FirstName);
				EmployeeParam.Add("@LastName", Request.LastName);
				EmployeeParam.Add("@MiddleName", Request.MiddleName);
				EmployeeParam.Add("@Gender", Request.Gender);
				EmployeeParam.Add("@Email", Request.Email);
				EmployeeParam.Add("@MobileNo", Request.MobileNo);
				EmployeeParam.Add("@DateofBirth", Request.DateofBirth);
				EmployeeParam.Add("@DateofJoin", Request.DateofJoin);
				EmployeeParam.Add("@RegisterId", Request.RegisteredID);
				EmployeeParam.Add("@LoginID", Request.LoginID);

				//using (var con = new SqlConnection(GetConnectionString(dBName)))
				//{
				//}

			}
			catch (Exception ex)
			{

			}



			return Response;
		}
	}
}
