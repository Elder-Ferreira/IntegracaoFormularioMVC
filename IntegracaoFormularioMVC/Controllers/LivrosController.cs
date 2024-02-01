using IntegracaoFormularioMVC.Data;
using IntegracaoFormularioMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
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

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            LivrosModel livro = _db.Livros.FirstOrDefault(x => x.Id == id);

            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        [HttpGet]
        public IActionResult Excluir(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            LivrosModel livro = _db.Livros.FirstOrDefault(x => x.Id == id);

            if (livro == null)
            {
                return NotFound();
            }

            return View(livro);
        }

        

        [HttpPost]
        public IActionResult Cadastrar(LivrosModel livros)
        {
            if (ModelState.IsValid)
            {
                _db.Livros.Add(livros);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Cadastro realizado com sucesso";

                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpPost]
        public IActionResult Editar(LivrosModel livro)
        {
            if (ModelState.IsValid)
            {
                _db.Livros.Update(livro);
                _db.SaveChanges();

                TempData["MensagemSucesso"] = "Edição realizada com sucesso";

                return RedirectToAction("Index");
            }

            TempData["MensagemErro"] = "Algum erro ocorreu ao realizar a edição";

            return View(livro);

        }

        [HttpPost]
        public IActionResult Excluir(LivrosModel livro)
        {
            if (livro == null)
            {
                return NotFound();
            }

            _db.Livros.Remove(livro);
            _db.SaveChanges();

            TempData["MensagemSucesso"] = "Remoção realizada com sucesso";

            return RedirectToAction("Index");
        }
    }
}
