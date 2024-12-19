using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web13.Models;
using static Web13.Models.Question;

namespace Web13.Controllers
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
        public IActionResult Quiz()
        {
            ResultSheet.Clear();
            Question question = new Question();
            ResultSheet.Add(question);
            return View(question);
        }
        [HttpPost]
        public IActionResult Quiz(Question question, string action)
        {
            if (!ModelState.IsValid)
            {
                return View(ResultSheet.questionList.Last());
            }
            ResultSheet.questionList.Last().guess = question.guess;
            ResultSheet.total++;
            if (ResultSheet.questionList.Last().answer == Convert.ToInt32(question.guess))
            {
                ResultSheet.correct++;
            }

            if (action == "Finish") return View("QuizResults");

            Question next = new Question();
            ResultSheet.Add(next);
            return View(next);
        }

        public IActionResult QuizResults()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
