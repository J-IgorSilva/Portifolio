using ControleDeContatos.Data;
using ControleDeContatos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public List<ContatoModel> ListarTodosContatos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel EditarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(TodosContatos => TodosContatos.Id == id);
        }
        
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel EditarContato(ContatoModel contato)
        {
            ContatoModel editarContatoDb = EditarPorId(contato.Id);
            if (editarContatoDb == null) throw new System.Exception("Ñão foi possivel alterar esse contato");
            editarContatoDb.Nome = contato.Nome;
            editarContatoDb.Email = contato.Email;
            editarContatoDb.Celular = contato.Celular;

            _bancoContext.Contatos.Update(editarContatoDb);
            _bancoContext.SaveChanges();

            return editarContatoDb;
        }

        public bool Apagar(int id)
        {
            ContatoModel editarContatoDb = EditarPorId(id);
            if (editarContatoDb == null) throw new System.Exception("Ñão foi possivel encontrar esse contato");

            _bancoContext.Contatos.Remove(editarContatoDb);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
