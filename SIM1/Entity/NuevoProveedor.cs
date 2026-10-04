using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class NuevoProveedor
    {
        [Required]
        public int tipoTransaccion { get; set; }

        [Required]
        [MaxLength(10)]
        public string IDjuridica { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string nombreEmpresa { get; set; } = string.Empty;

        [Required]
        [MaxLength(75)]
        public string nombreContacto { get; set; } = string.Empty;

        [Required]
        [MaxLength(8)]
        public string telefono { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        [MaxLength(75)]
        public string correo { get; set; } = string.Empty;

        [Required]
        public int estado { get; set; }
    }
}
