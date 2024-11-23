using Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Calculator.Services;

namespace Calculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICalcService _calcService;

        public HomeController(ILogger<HomeController> logger, ICalcService calcService)
        {
            _logger = logger;
            _calcService = calcService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModelCalc()
        {
            int tempNum1 = new Random().Next(0,10);
            int tempNum2 = new Random().Next(0,10);
            var viewModel = new CalcModel()
            {
                Num1 = tempNum1,
                Num2 = tempNum2,
                Add = tempNum1 + tempNum2,
                Sub = tempNum1 - tempNum2,
                Mult = tempNum1 * tempNum2,
                Div = tempNum2 != 0 ? (tempNum1 / tempNum2).ToString() : "Деление на ноль",
            };
            return View(viewModel);
        }
        public IActionResult ViewDataCalc()
        {
            int tempNum1 = new Random().Next(0, 10);
            int tempNum2 = new Random().Next(0, 10);
            ViewData["Num1"] = tempNum1;
            ViewData["Num2"] = tempNum2;
            ViewData["Add"] = tempNum1 + tempNum2;
            ViewData["Sub"] = tempNum1 - tempNum2;
            ViewData["Mult"] = tempNum1 * tempNum2;
            ViewData["Div"] = tempNum2 != 0 ? (tempNum1 / tempNum2).ToString() : "Деление на ноль";

            return View();
        }

        public IActionResult ViewBagCalc()
        {
            int tempNum1 = new Random().Next(0, 10);
            int tempNum2 = new Random().Next(0, 10);
            ViewBag.Num1 = tempNum1;
            ViewBag.Num2 = tempNum2;
            ViewBag.Add = tempNum1 + tempNum2;
            ViewBag.Sub = tempNum1 - tempNum2;
            ViewBag.Mult = tempNum1 * tempNum2;
            ViewBag.Div = tempNum2 != 0 ? (tempNum1 / tempNum2).ToString() : "Деление на ноль";

            return View();
        }

        public IActionResult ServiceInjectionCalc()
        {
            int tempNum1 = new Random().Next(0, 10);
            int tempNum2 = new Random().Next(0, 10);
            ViewBag.Num1 = tempNum1;
            ViewBag.Num2 = tempNum2;
            ViewBag.Add = _calcService.Add(tempNum1, tempNum2);
            ViewBag.Sub = _calcService.Sub(tempNum1, tempNum2);
            ViewBag.Mult = _calcService.Mult(tempNum1, tempNum2);
            ViewBag.Div = _calcService.Div(tempNum1, tempNum2);

            return View("ServiceInjectionCalc");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
