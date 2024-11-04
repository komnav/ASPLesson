using ASPLesson.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPLesson.Controllers
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
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            var user = new List<User>
            {
                new User{Name="Khabib",Age  =3},
                new User{Name="Khamid",Age  =2},
                new User{Name="Mustafo",Age  =1}
            };

            return View(user);
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
