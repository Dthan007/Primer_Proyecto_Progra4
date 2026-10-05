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
                "PROVEEDOR|" +
                cmbTipoTransaccion.SelectedIndex + "|" +
                txtIDjuridica.Text + "|" +
                txtNombre.Text + "|" +
                txtNomContacto.Text + "|" +
                txtTelefono.Text + "|" +
                txtCorreo.Text + "|" +
                cmbEstado.SelectedIndex;

            EnviarConsulta proveedorBLL = new EnviarConsulta();
            string respuesta = proveedorBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
