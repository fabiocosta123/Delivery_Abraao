using Delivery_Abraao.Models;
using Delivery_Abraao.Repositories.Interfaces;
using Delivery_Abraao.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Delivery_Abraao.Controllers
{

    
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public HomeController(ILancheRepository lancheRepository, ILogger<HomeController> logger)
        {
            _lancheRepository = lancheRepository;
            _logger = logger;
        }

        private readonly ILogger<HomeController> _logger;

        //public HomeController()
        //{
            
        //}

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };
            return View(homeViewModel);
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
