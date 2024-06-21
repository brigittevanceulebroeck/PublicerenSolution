using Microsoft.AspNetCore.Mvc;
using PublicerenWeb.Entities;
using PublicerenWeb.Models;
using System.Diagnostics;

namespace PublicerenWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly IActiecodeRepository actiecodeRepository;

        public HomeController(IActiecodeRepository actiecodeRepository)
        {
           this.actiecodeRepository = actiecodeRepository;
        }

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
