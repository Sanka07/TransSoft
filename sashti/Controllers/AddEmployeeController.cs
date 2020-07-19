using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sashti.Controllers
{
	public class AddEmployeeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
