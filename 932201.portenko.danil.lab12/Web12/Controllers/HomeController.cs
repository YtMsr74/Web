using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis.Elfie.Model;
using System.Collections.Generic;
using System.Diagnostics;
using Web12.Models;

namespace Web12.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult ManualSingle()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ManualSingle(IFormCollection form) {
			var form1 = form["num1"];
			var form2 = form["num2"];
			var formOper = form["operation"];
			if (double.TryParse(form1, out double num1) && double.TryParse(form2, out double num2))
			{
                ViewBag.Result = Calculate(num1, num2, formOper);
                return View("Result");
            }
			else
			{
				ViewBag.Error = "Îøèáêà â ââåä¸ííûõ ÷èñëàõ";
				return View();
			}
		}

		[HttpGet]
		public IActionResult ModelParameters()
		{ 
			return View();
        	}
        	[HttpPost]
		public IActionResult ModelParameters(double num1, double num2, string operation)
		{
			ViewBag.Resutl = Calculate(num1, num2, operation);
			return View("Result");
		}

		[HttpGet, ActionName("ManualSeperate")]
		public IActionResult ManualSeperateGet()
		{
			return View();
		}

		[HttpPost, ActionName("ManualSeperate")]
        public IActionResult ManualSeperatePost()
        {
            if (double.TryParse(Request.Form["num1"], out double num1) && double.TryParse(Request.Form["num2"], out double num2))
            {
                ViewBag.Result = Calculate(num1, num2, Request.Form["operation"]);
                return View("Result");
            }
            else
            {
                ViewBag.Error = "Îøèáêà â ââåä¸ííûõ ÷èñëàõ";
                return View();
            }
        }

        [HttpGet]
		public IActionResult ModelSeperate()
		{
			return View();
		}

		[HttpPost]
		public IActionResult ModelSeperate(CalcModel calc)
		{
			ViewBag.Result = Calculate(calc.Num1, calc.Num2, calc.Operation);
			return View("Result");
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		private string Calculate(double num1, double num2, string oper)
		{
			switch (oper)
			{
				case "+":
					return $"{num1} + {num2} = " + (num1 + num2);
				case "-":
                    return $"{num1} - {num2} = " + (num1 - num2);
				case "*":
                    return $"{num1} * {num2} = " + (num1 * num2);
				case "/":
					if (num2 != 0)
					{
						return $"{num1} / {num2} = " + (num1 / num2);
                    }
					else
					{
                        return $"Äåëåíèå íà íîëü";
                    }
            }
			return $"îøèáêà";
		}
	}
}
