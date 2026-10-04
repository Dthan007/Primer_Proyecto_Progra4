using BLL;

namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscIngreso_Proveedor : UserControl
    {
        public uscIngreso_Proveedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string trama =
                "PROVEEDOR" +
                (cmbTipoTransaccion.SelectedItem?.ToString() ?? "") + "|" +
                txtIDjuridica.Text + "|" +
                txtNombre.Text + "|" +
                txtTelefono.Text + "|" +
                txtNomContacto.Text + "|" +
                txtCorreo.Text + "|" +
                (cmbEstado.SelectedItem?.ToString() ?? "");

            EnviarConsulta proveedorBLL = new EnviarConsulta();
            string respuesta = proveedorBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
