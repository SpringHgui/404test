using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web404.Models;

namespace Web404.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/test404")]
        public IActionResult test404()
        {
            // return NotFound();
            return StatusCode(404);
        }

        [Route("test401")]
        public IActionResult test401()
        {
            return StatusCode(401);
        }

        ///// <summary>
        ///// 无法处理程序抛出的404
        ///// </summary>
        ///// <returns></returns>
        //[Route("{*url}", Order = 9999)]
        //public IActionResult Page404()
        //{
        //    return View();
        //}
    }
}