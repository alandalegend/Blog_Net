using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Modelo.POCOs
{
    [Table("CatalogoEstatusEntrada")]
    public class CatalogoEstatusEntrada
    {
        [Key]
        public int CatalogoEstatusEntradaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), Display(Name = "Descripción del Estatus")]
        public String DescripcionCatalogo { get; set; }
    }
}
