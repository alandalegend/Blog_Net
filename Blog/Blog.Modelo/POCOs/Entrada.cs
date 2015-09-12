using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Web.Mvc;

namespace Blog.Modelo.POCOs
{
    /// <summary>
    /// Modelo de la clase que contendrá el cuerpo de las entradas, podrás ingresar imagen principal de la entrada y esta será alojada en Base64
    /// </summary>
    [Table("Entradas")]
    public class Entrada
    {
        [Key]
        public Guid EntradaId { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), Display(Name = "Titulo de la Entrada")]
        public String Titulo { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio"), Display(Name = "Contenido de la Entrada"), AllowHtml]
        public String Contenido { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime  FechaDeCreacion { get; set; }

        [Display(Name = "Fecha de Publicación")]
        public DateTime  FechaDePublicacion { get; set; }

        [Display(Name = "Fecha de Última Edición")]
        public DateTime FechaDeUltimaEdicion { get; set; }

        [Display(Name = "Tags de la Entrada")]
        public String Tags { get; set; }

        [Display(Name = "Estatus de la Entrada")]
        public virtual CatalogoEstatusEntrada Estatus { get; set; }

        [Display(Name = "Autor de la Entrada")]
        public virtual Autor Autor { get; set; }

        [Display(Name = "Imagen Principal de la Entrada")]
        public Byte[] ImagenesEntrada { get; set; }

        [NotMapped, Display(Name = "Imagen principal de la Entrada en Base64")]
        public String ImagenPrincipalBase64 { get; set; }

        [NotMapped, DataType(DataType.Upload), Display(Name = "Imagen principal de la Entrada")]
        public HttpPostedFileBase SubirImagen { get; set; }

    }
}
