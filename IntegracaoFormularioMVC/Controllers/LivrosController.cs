using Microsoft.AspNetCore.Mvc;

namespace IntegracaoFormularioMVC.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
