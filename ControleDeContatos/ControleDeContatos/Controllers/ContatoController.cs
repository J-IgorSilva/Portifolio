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
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemDeSucesso"] = "Contato Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato{erro.Message}";
                return RedirectToAction("Index");
            }

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
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemDeSucesso"] = "Contato Cadastrado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(contato);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu contato{erro.Message}";
                return RedirectToAction("Index");
            }   
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
