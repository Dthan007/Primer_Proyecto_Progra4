using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class NuevoProducto
    {
        [Required]
        public int transaccion { get; set; }

        [Required]
        [MaxLength(10)]
        public string producto { get; set; } = string.Empty;

        [Required]
        [MaxLength(90)]
        public string nombre { get; set; } = string.Empty;

        [Required]
        [MaxLength(8)]
        public double precio { get; set; }
    }
}
