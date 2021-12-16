using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCatalago
{
    public class Series : EnityBase
    {
        private Genero genero;

        //atributes
        private Genero Gerero { get; set; }
        private string Titulo { get; set; }
        private string Description { get; set; }
        private int Ano { get; set; } 
        private bool excluir { get; set; }

        // methods

        public Series (int id , Genero genero, string titulo, string description, int ano, bool excluir) 
        {
            this.Id = id;
            this.Gerero = genero;
            this.Titulo = titulo;
            this.Description = description;
            this.Ano = ano;
            this.excluir = false; // para marcar se foi ou não excluido. necessitou criar um novo methodo
        }

        public Series(int id, Genero genero, string titulo, int ano, string description)
        {
            Id = id;
            this.genero = genero;
            Titulo = titulo;
            Ano = ano;
            Description = description;
        }

        public override string ToString()
        {
            string retorno = " ";
            retorno += "Genero: " + this.Gerero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Description: " + this.Description + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano;
            return retorno;
        }
        // methodo para evitar ficar alterando 'id/tt' ja que estão como private
        public string retornTitulo()
        {
            return this.Titulo;
        }
        internal int retornId()
        {
            return this.Id;
        }
        public void Excluir() // metodo para ajudar a marcar o item excluido.
        {
            this.excluir = true;
        }

    
    }
}
