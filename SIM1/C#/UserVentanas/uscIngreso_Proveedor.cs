namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    public partial class uscIngreso_Proveedor : UserControl
    {
        Entity.NuevoProveedor dato = new Entity.NuevoProveedor();
        BLL.NuevoProveedorbll proveedor = new BLL.NuevoProveedorbll();

        public uscIngreso_Proveedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarEspacios() == true && validaNumeros() == true)
                {
                    dato.tipoTransaccion = cmbTipoTransaccion.SelectedIndex;
                    dato.IDjuridica = txtIDjuridica.Text;
                    dato.nombreEmpresa = txtNombre.Text;
                    dato.telefono = txtTelefono.Text;
                    dato.nombreContacto = txtNomContacto.Text;
                    dato.correo = txtCorreo.Text;
                    dato.estado = cmbEstado.SelectedIndex;
                    if (MessageBox.Show(
                        "¿Está seguro de que desea aceptar la transacción?",
                        "Confirmar transacción",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        limpiarEspacios();
                        string trama = proveedor.ConstruirTrama(dato);
                        string respuesta = proveedor.ProcesarProveedor(dato);
                    }
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
                string.IsNullOrEmpty(txtIDjuridica.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(txtNomContacto.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(cmbEstado.SelectedItem?.ToString()))
            {
                MessageBox.Show(
                    "No hay datos para cancelar.",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }
            if (MessageBox.Show(
                "¿Está seguro de que desea cancelar la transacción?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                limpiarEspacios();
            }
        }

        private bool validarEspacios()
        {
            if (cmbTipoTransaccion.SelectedIndex == -1 ||
                string.IsNullOrEmpty(txtIDjuridica.Text) ||
                string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtTelefono.Text) ||
                string.IsNullOrEmpty(txtNomContacto.Text) ||
                string.IsNullOrEmpty(txtCorreo.Text) ||
                string.IsNullOrEmpty(cmbEstado.SelectedItem?.ToString()))
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
            txtIDjuridica.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtNomContacto.Clear();
            txtCorreo.Clear();
            cmbEstado.SelectedIndex = -1;
        }

        private bool validaNumeros()
        {
            if (!long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show(
                    "El campo de teléfono debe contener solo números.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!long.TryParse(txtIDjuridica.Text, out _))
            {
                MessageBox.Show(
                    "El campo de ID jurídica debe contener solo números.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (!txtCorreo.Text.Contains("@") || !txtCorreo.Text.Contains("."))
            {
                MessageBox.Show(
                    "El campo de correo electrónico no es válido.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtNomContacto.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El campo de nombre de contacto no debe contener números.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (txtNombre.Text.Any(char.IsDigit))
            {
                MessageBox.Show(
                    "El campo de nombre de empresa no debe contener números.",
                    "Error de validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;



        }
    }
}
