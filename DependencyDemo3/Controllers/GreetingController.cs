using DependencyDemo3.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependencyDemo3.Controllers
{
    // Built from https://www.youtube.com/watch?v=5A2UxMGA58g
    public class GreetingController : Controller
    {
        private IGreetingService _greetingService;
        private IGreetingService _secondService;

        public GreetingController(IGreetingService greetingService, IGreetingService secondService)
        {
            _greetingService = greetingService;
            _secondService = secondService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["massage"] = _greetingService.GetGreeting() + _secondService.GetGreeting();
            return View();
        }
    }
}
