using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel EditarPorId(int id);
        List<ContatoModel> ListarTodosContatos();
        ContatoModel Adicionar(ContatoModel contato);
        ContatoModel EditarContato(ContatoModel contato);

    }

}
