using ControleDeContatos.Models;
using System.Collections.Generic;

namespace ControleDeContatos.Repositorio
{
    public interface IContatoRepositorio
    {
        ContatoModel ListarContato(int id);
        List<ContatoModel> BuscarContatos();
        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel CriarContato(ContatoModel contato);
        ContatoModel AlterarContatos(ContatoModel contato);

        bool Apagar(int id);

    }
}
