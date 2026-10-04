using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class CompraProveedor
    {
        [Required]
        public int transaccion { get; set; }

        [Required]
        [MaxLength(10)]
        public string NoIngreso { get; set; } = string.Empty;

        [Required]
        [MaxLength(10)]
        public DateOnly fecha { get; set; }

        [Required]
        public int listaProductos { get; set; }

        [Required]
        [MaxLength(10)]
        public string NoProducto { get; set; } = string.Empty;

        [Required]
        [MaxLength(7)]
        public string cantidad { get; set; } = string.Empty;
    }
}
