using Sashti.Model.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sashti.Model.Employee
{
	public class EmployeeRequest: CommonEmployee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public string Gender { get; set; }
		public string Email { get; set; }
		public string MobileNo { get; set; }
		public DateTime DateofBirth { get; set; }
		public DateTime DateofJoin { get; set; }
	}

	public class EmployeeBankRequest: CommonEmployee
	{
		public string AccountNo { get; set; }
		public string IFSCCode { get; set; }
		public string BankName { get; set; }
		public string AccountName { get; set; }
		public string AccountType { get; set; }
	}

	public class EmployeeJobHistory:CommonEmployee
	{
		public string JobId { get; set; }
		public string Dept_Id { get; set; }
		public DateTime fromdate { get; set; }
		public DateTime todate { get; set; }		
	}
}
