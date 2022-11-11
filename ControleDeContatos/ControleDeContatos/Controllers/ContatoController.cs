using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> listagemContatos = _contatoRepositorio.ListarTodosContatos();
            return View(listagemContatos);
        }
        public IActionResult CriarContato()
        {
            return View();
        }
        public IActionResult EditarContato(int id)
        {
            ContatoModel contatoEditado =_contatoRepositorio.EditarPorId(id);
            return View(contatoEditado);
        }
        public IActionResult ApagarContato(int id) //Confirmação se quer apagar o contato
        {
            ContatoModel contatoEditado = _contatoRepositorio.EditarPorId(id);
            return View(contatoEditado);
        }
        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index"); //Apos apagar volta para a Index
        }
        
        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditarContato(ContatoModel contato)
        {
            _contatoRepositorio.EditarContato(contato);
            return RedirectToAction("Index");
        }
    }
}
