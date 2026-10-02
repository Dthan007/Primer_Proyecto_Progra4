namespace Sistema_de_Ventas_y_Distribución
{
    public partial class uscIngreso_Mantenimiento : UserControl
    {
        Entity.NuevoProducto dato = new Entity.NuevoProducto();
        BLL.NuevoProductobll producto = new BLL.NuevoProductobll();
        
        public uscIngreso_Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarEspacios() == true && validaNumeros() == true)
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
                    
                    string trama = producto.ConstruirTrama(dato);
                    

                } else { return; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al procesar la transacción: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }//btnAceptar_Click().

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

        }//btnCancelar_Click().

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
        }//ValidarEspacios().

        private void limpiarEspacios()
        {
            cmbTipoTransaccion.SelectedIndex = -1;
            txtNoProducto.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
        }//limpiarEspacios().

        #region Validaciones de números y caracteres
        private bool validaNumeros()
        {

            if (!txtNoProducto.Text.All(char.IsDigit))
            {
                MessageBox.Show(
                    "Por favor, ingrese un número de producto válido.",
                    "Número de producto inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (txtNoProducto.Text.Length > 10 || txtNoProducto.Text.Length < 10)
            {
                MessageBox.Show(
                    "El número de producto debe ser de 10 dígitos.",
                    "Número de producto inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(txtPrecio.Text, out double precio))
            {
                MessageBox.Show(
                    "Por favor, ingrese un precio válido.",
                    "Precio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (precio <= 0)
            {
                MessageBox.Show(
                    "El precio no puede ser cero o negativo.",
                    "Precio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (txtPrecio.Text.Length > 8)
            {
                MessageBox.Show(
                    "El precio no puede tener más de 8 dígitos.",
                    "Precio inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (txtNombre.Text.Length > 90)
            {
                MessageBox.Show(
                    "El nombre del producto no puede tener más de 90 caracteres.",
                    "Nombre de producto inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }//validaNumeros().
        #endregion
    }//uscIngreso_Mantenimiento.
}//Sistema_de_Ventas_y_Distribución. 