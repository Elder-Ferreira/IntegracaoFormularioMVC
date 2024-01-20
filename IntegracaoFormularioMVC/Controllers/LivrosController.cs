using IntegracaoFormularioMVC.Data;
using IntegracaoFormularioMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace IntegracaoFormularioMVC.Controllers
{
    public class LivrosController : Controller
    {
        readonly private ApplicationDbContext _db;

        public LivrosController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<LivrosModel> livros = _db.Livros;

            return View(livros);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
