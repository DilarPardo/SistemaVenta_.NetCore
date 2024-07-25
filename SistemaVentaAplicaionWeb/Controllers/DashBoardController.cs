using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicaionWeb.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
