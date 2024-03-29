﻿using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do contato")]
        public string Nome  { get; set; }

        [Required(ErrorMessage ="Digite o email do contato")]
        [EmailAddress(ErrorMessage ="Email invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Digite o celular do contato")]
        [Phone(ErrorMessage ="Celular invalido")]
        public string Celular { get; set; }
    }
}
