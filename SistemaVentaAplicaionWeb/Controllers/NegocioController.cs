using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicaionWeb.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
