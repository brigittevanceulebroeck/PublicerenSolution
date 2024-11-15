using Microsoft.AspNetCore.Mvc;
using PublicerenWeb.Entities;
using PublicerenWeb.Models;
using System.Diagnostics;

namespace PublicerenWeb.Controllers
{
    public class HomeController(IActiecodeRepository actiecodeRepository) : Controller
    {
        private readonly IActiecodeRepository actiecodeRepository = actiecodeRepository;

        public async Task<IActionResult> Index()
        {
            return View(await actiecodeRepository.GetAll());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
