using BLL;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscIngreso_Producto : UserControl
    {
        public uscIngreso_Producto()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string trama =
                "PRODUCTO" +
                (cmbTipoTransaccion.SelectedItem?.ToString() ?? "") + "|"+
                txtNoProducto.Text + "|" +
                txtNombre.Text + "|" +
                txtPrecio.Text;

            EnviarConsulta productoBLL = new EnviarConsulta();
            string respuesta = productoBLL.ProcesarElemento(trama);

            MessageBox.Show(respuesta, "Respuesta del Servidor", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }//btnAceptar_Click().
    }//uscIngreso_Mantenimiento.
}//Sistema_de_Ventas_y_Distribución. 