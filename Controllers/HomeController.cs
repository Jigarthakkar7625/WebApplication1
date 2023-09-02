using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication.Data.Models;
using WebApplication.Service.IServices;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUsers _users;
        //private readonly TestAvinashContext _testAvinashContext;

        public HomeController(ILogger<HomeController> logger, IUsers users)
        {
            _logger = logger;
            _users = users;
            //_testAvinashContext = testAvinashContext;
        }

        public IActionResult Index()
        {
            //TestAvinashContext _testAvinashContext = new TestAvinashContext();
            var a = _users.GetUsers();

            //var abc = _testAvinashContext.Users.ToList();


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