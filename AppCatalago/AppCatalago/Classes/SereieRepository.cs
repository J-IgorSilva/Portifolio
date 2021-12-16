using AppCatalago.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalago
{
    public class SereieRepository : IRepository<Series>
    {
        private List<Series> listaSerie = new List<Series>();
        public void Atualizar(int id, Series entidade)
        {
            listaSerie[id] = entidade;
        }

        public void Delete(int id) // necessidade de dizer se o id foi excluido
        {
            listaSerie[id].Excluir();
        }

        public void Excluir(int indiceSerie)
        {
            throw new NotImplementedException();
        }

        public void Insere(Series entidade) // poderia mudar o nome para deixar mais claro
        {
            listaSerie.Add(entidade);
        }

        public List<Series> lista()
        {
            return listaSerie;
        }

        public int ProximoId() // shar me sugeriu o count, pesquisei e serviu direitinho
        {
            return listaSerie.Count; 
        }

        public Series RetoronoId(int id)
        {
            return listaSerie[id];
        }
    }
}
