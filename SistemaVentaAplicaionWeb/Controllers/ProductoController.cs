using Microsoft.AspNetCore.Mvc;

namespace SistemaVentaAplicaionWeb.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
