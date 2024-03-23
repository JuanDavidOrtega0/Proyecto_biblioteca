using Microsoft.AspNetCore.Mvc;
namespace Biblioteca.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}