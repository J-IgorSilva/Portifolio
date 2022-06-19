using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokemon.Application.Data.MySql.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("creationdate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Column("updatedate")]
        public DateTime UpdateDate { get; set; } = DateTime.Now;

    }
}