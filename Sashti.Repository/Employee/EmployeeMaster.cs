using Sashti.Model.Employee;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace Sashti.Repository.Employee
{
	public class EmployeeMaster : IEmployeeMaster
	{
		private IDbConnection _dbconnection;

		public EmployeeMaster(IDbConnection dbconnection)
		{
			_dbconnection = dbconnection;
		}

		async Task<List<EmployeeResponse>> IEmployeeMaster.GetEmployees()
		{
			List<EmployeeResponse> Response = new List<EmployeeResponse>();

			try
			{
				using (var con=new SqlConnection(_dbconnection.ConnectionString))
				{
					var GetEmpParam = new DynamicParameters();

					var EmpResponse =await con.QueryAsync<EmployeeResponse>(StoreProceudreName.GetEmployee, GetEmpParam, commandType: CommandType.StoredProcedure);

					Response = EmpResponse.ToList();
				}
			}
			catch(Exception ex)
			{

			}
			return Response;
		}
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

				using (_dbconnection)
				{

				}

			}
			catch (Exception ex)
			{

			}



			return Response;
		}
	}
}
