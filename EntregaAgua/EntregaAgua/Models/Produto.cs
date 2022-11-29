using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntregaAgua.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name="Codigo")]
        public int Id { get; set; }

        [Column("Agua")]
        [Display(Name = "Pedido")]
        public int Agua { get; set; }

        [Column("Entregador")]
        [Display(Name = "Entregador")]
        public int Entregador { get; set; }

        [Column("Cliente")]
        [Display(Name = "Cliente")]
        public string Cliente { get; set; }
    }

}
