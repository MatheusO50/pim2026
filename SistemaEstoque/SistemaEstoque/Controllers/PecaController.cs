using Microsoft.AspNetCore.Mvc;
using SistemaEstoque.Data;
using SistemaEstoque.Models;

namespace SistemaEstoque.Controllers
{
    public class PecaController : Controller
    {
        private readonly AppDbContext _context;
        public PecaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var pecas = _context.Pecas.ToList();
            return View(pecas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Peca peca)
        {
            if (ModelState.IsValid)
            {
                _context.Pecas.Add(peca);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(peca);
        }

        public IActionResult Edit(int id)
        {
            var peca = _context.Pecas.Find(id);
            return View(peca);
        }

        [HttpPost]
        public IActionResult Edit(Peca peca)
        {
            _context.Pecas.Update(peca);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var peca = _context.Pecas.Find(id);
            return View(peca);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var peca = _context.Pecas.Find(id);

            _context.Pecas.Remove(peca);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
