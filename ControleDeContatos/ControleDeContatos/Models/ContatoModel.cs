using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Insira o Nome do contato")]
        public string Nome  { get; set; }

        [Required(ErrorMessage = "Insira o Email do contato")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Insira o Celular do contato")]
        [Phone(ErrorMessage = "Telefone invalido")]
        public string Celular { get; set; }
    }
}
