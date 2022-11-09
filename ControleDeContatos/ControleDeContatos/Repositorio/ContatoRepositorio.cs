using ControleDeContatos.Data;
using ControleDeContatos.Models;
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

       
    }
}
