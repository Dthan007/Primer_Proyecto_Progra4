namespace Sistema_de_Ventas_y_Distribución
{
    partial class uscIngreso_Mantenimiento
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            cmbTipoTransaccion = new ComboBox();
            lblTipoTransaccion = new Label();
            lblNoProducto = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            txtNoProducto = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // cmbTipoTransaccion
            // 
            cmbTipoTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoTransaccion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoTransaccion.FormattingEnabled = true;
            cmbTipoTransaccion.Items.AddRange(new object[] { "1: Ingreso", "2: Modificación" });
            cmbTipoTransaccion.Location = new Point(166, 28);
            cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            cmbTipoTransaccion.Size = new Size(158, 29);
            cmbTipoTransaccion.TabIndex = 1;
            // 
            // lblTipoTransaccion
            // 
            lblTipoTransaccion.AutoSize = true;
            lblTipoTransaccion.Font = new Font("Segoe UI", 12F);
            lblTipoTransaccion.Location = new Point(13, 26);
            lblTipoTransaccion.Name = "lblTipoTransaccion";
            lblTipoTransaccion.Size = new Size(147, 21);
            lblTipoTransaccion.TabIndex = 0;
            lblTipoTransaccion.Text = "Tipo de transacción:";
            // 
            // lblNoProducto
            // 
            lblNoProducto.AutoSize = true;
            lblNoProducto.Font = new Font("Segoe UI", 12F);
            lblNoProducto.Location = new Point(59, 76);
            lblNoProducto.Name = "lblNoProducto";
            lblNoProducto.Size = new Size(101, 21);
            lblNoProducto.TabIndex = 0;
            lblNoProducto.Text = "No Producto:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(89, 126);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F);
            lblPrecio.Location = new Point(104, 225);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(56, 21);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio:";
            // 
            // txtNoProducto
            // 
            txtNoProducto.Font = new Font("Segoe UI", 12F);
            txtNoProducto.Location = new Point(166, 78);
            txtNoProducto.Name = "txtNoProducto";
            txtNoProducto.Size = new Size(158, 29);
            txtNoProducto.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(166, 128);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(158, 71);
            txtNombre.TabIndex = 3;
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(166, 225);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(158, 29);
            txtPrecio.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(366, 165);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 34);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(366, 225);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // uscIngreso_Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtNoProducto);
            Controls.Add(lblPrecio);
            Controls.Add(lblNombre);
            Controls.Add(lblNoProducto);
            Controls.Add(lblTipoTransaccion);
            Controls.Add(cmbTipoTransaccion);
            Name = "uscIngreso_Mantenimiento";
            Size = new Size(520, 303);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipoTransaccion;
        private Label lblTipoTransaccion;
        private Label lblNoProducto;
        private Label lblNombre;
        private Label lblPrecio;
        private TextBox txtNoProducto;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
