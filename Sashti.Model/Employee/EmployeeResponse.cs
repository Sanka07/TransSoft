﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sashti.Model.Employee
{
	public class EmployeeResponse
	{
		public string EmpId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string MobileNo { get; set; }
	}

	public class JobTitleResponse
	{
		public string JobID { get; set; }
		public string JobTitle { get; set; }
	}

	public class DepartmentResponse
	{
		public string DeptId { get; set; }
		public string Department { get; set; }
	}

	public class JobtitleandDepartment
	{
		public List<JobTitleResponse> JobTitle { get; set; }
		public List<DepartmentResponse> Departments { get; set; }
	}
}
