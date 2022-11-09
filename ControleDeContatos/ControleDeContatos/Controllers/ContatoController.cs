using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public private readonly
        public ContatoController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CriarContato()
        {
            return View();
        }
        public IActionResult EditarContato()
        {
            return View();
        }
        public IActionResult ApagarContato()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {

        }
    }
}
