using ControleDeContatos.Data;
using ControleDeContatos.Models;
using System;
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

        public ContatoModel ListarContato(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x=>x.Id == id);
        }
        public List<ContatoModel> BuscarContatos()
        {
            return _bancoContext.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoEditarDB = ListarContato(id);
            if (contatoEditarDB == null)
            {
                throw new SystemException("Houve um erro ao apagar o contato");
            }
            _bancoContext.Contatos.Remove(contatoEditarDB);
            _bancoContext.SaveChanges();
            return true;
        }

        public ContatoModel AlterarContatos(ContatoModel contato)
        {
            ContatoModel contatoEditarDB = ListarContato(contato.Id);
            if(contatoEditarDB == null)
            {
                throw new SystemException("Houve um erro ao alterar o contato");
            }
            contatoEditarDB.Nome = contato.Nome;
            contatoEditarDB.Email = contato.Email;
            contatoEditarDB.Celular = contato.Celular;

            _bancoContext.Contatos.Update(contatoEditarDB);
            _bancoContext.SaveChanges();
            return contatoEditarDB;
        }
        public ContatoModel CriarContato(ContatoModel contato)
        {
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

    }
}
