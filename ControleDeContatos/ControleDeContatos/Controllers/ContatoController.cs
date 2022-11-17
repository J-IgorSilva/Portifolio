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
            List<ContatoModel> contatos = _contatoRepositorio.BuscarContatos();
            return View(contatos);
        }
        public IActionResult CriarContato(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
            
        }
        public IActionResult EditarContato(int id)
        {
            ContatoModel contatoPorId = _contatoRepositorio.ListarContato(id);
            return View(contatoPorId);
        }
        public IActionResult ApagarConfirma(int id) //Pede ao ususario que confirme se que apagar o registro do contato
        {
            ContatoModel contatoPorId = _contatoRepositorio.ListarContato(id);
            return View(contatoPorId);
        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
            
        }
        [HttpPost]
        public IActionResult AlterarContato(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.AlterarContatos(contato);
                return RedirectToAction("Index");
            }
            return View("EditarContato",contato);
           
        }

        [HttpGet]
        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

    }
}
