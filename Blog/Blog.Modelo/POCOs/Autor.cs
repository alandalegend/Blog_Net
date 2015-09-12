using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Modelo.POCOs
{
    [Table("Autores")]
    public class Autor : Usuario
    {
        [Key]
        public Guid AutorId { get; set; }
    }
}
