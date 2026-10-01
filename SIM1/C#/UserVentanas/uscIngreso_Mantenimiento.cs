namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscIngreso_Mantenimiento : UserControl
    {
        Entity.NuevoProducto dato = new Entity.NuevoProducto();

        public uscIngreso_Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarEspacios() == true)
                {
                    dato.transaccion = cmbTipoTransaccion.SelectedIndex;
                    dato.producto = txtNoProducto.Text;
                    dato.nombre = txtNombre.Text;
                    dato.precio = double.Parse(txtPrecio.Text);
                    MessageBox.Show(
                        "¿Está seguro de que desea aceptar la transacción?",
                        "Confirmar transacción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    limpiarEspacios();

                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al procesar la transacción: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (cmbTipoTransaccion.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtNoProducto.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show(
                    "No hay datos para cancelar.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (MessageBox.Show(
                    "¿Está seguro de que desea cancelar la operación?",
                    "Confirmar cancelación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiarEspacios();
            }

        }

        private bool ValidarEspacios()
        {
            if (cmbTipoTransaccion.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtNoProducto.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show(
                    "Por favor, complete todos los campos.",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void limpiarEspacios()
        {
            cmbTipoTransaccion.SelectedIndex = -1;
            txtNoProducto.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }
    }
}