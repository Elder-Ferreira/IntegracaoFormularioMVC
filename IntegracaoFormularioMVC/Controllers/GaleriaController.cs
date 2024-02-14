using IntegracaoFormularioMVC.Data;
using IntegracaoFormularioMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace IntegracaoFormularioMVC.Controllers
{
    public class GaleriaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public GaleriaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ActionResult<List<ImagemModel>>> Index()
        {
            var imagens = await _context.Imagens.ToListAsync();
            return View();
        }
    }
}

