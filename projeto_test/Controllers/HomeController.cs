using Microsoft.AspNetCore.Mvc;
using projeto_test.Entidades;
using projeto_test.Models;
using System.Diagnostics;

namespace projeto_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Contexto db;
        public HomeController(ILogger<HomeController> logger, Contexto _db)
        {
            db = _db;
            _logger = logger;
        }

        public IActionResult Index(string busca)
        {
            List<Medicamentos> model = new List<Medicamentos>();
            if (string.IsNullOrEmpty(busca))
            {
                return View(model);
            }
            else
            {
                model = db.Medicamentos.Where(a =>
                    a.Descricao.Contains(busca) ||
                    a.Tipo.Contains(busca) ||
                    a.Nome.Contains(busca)
                    ).ToList();
                return View(model);
            }
           
        }

        public IActionResult Sobre()
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