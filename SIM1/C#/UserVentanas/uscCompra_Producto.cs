using BLL;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscCompra_Producto : UserControl
    {
        public uscCompra_Producto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string trama =
                "COMPRA|" +
                cmbProductos.SelectedIndex + "|" +
                txtIngreso.Text + "|" +
                txtCompra.Text + "|" +
                txtJuridica.Text + "|" +
                txtNoProducto.Text + "|" +
                txtCantidad.Text;

            EnviarConsulta compraProveedorBLL = new EnviarConsulta();
            string respuesta = compraProveedorBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
