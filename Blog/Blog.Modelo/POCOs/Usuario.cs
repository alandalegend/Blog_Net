using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Blog.Modelo.POCOs
{
    /// <summary>
    /// Clase que se encargará de tener el formato del Usuario
    /// </summary>
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public Guid UsuarioId { get; set; }
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public String UserName { get; set; }
        public DateTime FechaIngreso { get; set; }
        public Boolean Activo { get; set; }

        [Display(Name = "Avatar del Usuario")]
        public Byte[] Avatar { get; set; }

        [NotMapped, Display(Name = "Avatar en Base64")]
        public String AvatarBase64 { get; set; }

        [NotMapped, DataType(DataType.Upload), Display(Name = "Subir Avatar")]
        public HttpPostedFileBase SubirAvatar { get; set; }
    }
}
