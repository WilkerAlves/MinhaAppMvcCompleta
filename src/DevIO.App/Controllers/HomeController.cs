using DevIO.App.ViewsModels;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevIO.App.Controllers
{
    public class HomeController : BaseController
    {
        private readonly INotificador _notificador;

        public HomeController(INotificador notificador) : base (notificador)
        {
            _notificador = notificador;
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
    }
}
