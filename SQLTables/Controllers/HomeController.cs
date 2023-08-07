using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLTables.Domain;
using SQLTables.Models;
using System.Diagnostics;

namespace SQLTables.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataManager dataManager;

        public HomeController(ILogger<HomeController> logger, DataManager dataManager)
        {
            _logger = logger;
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            var result = dataManager.BookRepository.GetAll()
                .Include(a => a.Author)
                .Include(g => g.Genre);
            return View(result);
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