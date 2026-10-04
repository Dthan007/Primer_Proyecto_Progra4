using BLL;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscCompra_Proveedor : UserControl
    {
        public uscCompra_Proveedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string trama =
                "COMPRA_PROVEEDOR   " +
                (cmbTransaccion.SelectedItem?.ToString() ?? "") + "|" +
                txtIngreso.Text + "|" +
                txtCompra.Text + "|" +
                txtJuridica.Text + "|" +
                (cmbTransaccion.SelectedIndex.ToString() ?? "") + "|" +
                txtNoProducto.Text + "|" +
                txtCantidad;

            EnviarConsulta compraProveedorBLL = new EnviarConsulta();
            string respuesta = compraProveedorBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
