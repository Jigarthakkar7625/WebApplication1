using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TestAvinashContext _testAvinashContext;

        public HomeController(ILogger<HomeController> logger, TestAvinashContext testAvinashContext)
        {
            _logger = logger;
            _testAvinashContext = testAvinashContext;
            //_testAvinashContext = testAvinashContext;
        }

        public IActionResult Index()
        {
            //TestAvinashContext _testAvinashContext = new TestAvinashContext();
            var a = _testAvinashContext.UserAddresses.ToList();

            var abc = _testAvinashContext.Users.ToList();


            return View();
        }

        public IActionResult Privacy()
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