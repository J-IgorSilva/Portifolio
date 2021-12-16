using System;
using System.Collections.Generic;


namespace AppCatalago.Interface
{
    public interface IRepository<T>
    {
        List<T> lista();
        T RetoronoId(int id);
        void Insere(T entidade);
        void Delete(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
        void Excluir(int indiceSerie);
    }
}
