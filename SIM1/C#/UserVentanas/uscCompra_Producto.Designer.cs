namespace Sistema_de_Ventas_y_Distribución.UserVentanas
{
    partial class uscCompra_Producto
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
            lblTipoTrans = new Label();
            cmbTransaccion = new ComboBox();
            lblNumIngreso = new Label();
            txtIngreso = new TextBox();
            txtCompra = new TextBox();
            lblFechaCompra = new Label();
            txtJuridica = new TextBox();
            lblIDjuridica = new Label();
            cmbProductos = new ComboBox();
            lblProductos = new Label();
            txtNoProducto = new TextBox();
            lblNoProducto = new Label();
            txtCantidad = new TextBox();
            lblCantidad = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTipoTrans
            // 
            lblTipoTrans.AutoSize = true;
            lblTipoTrans.Font = new Font("Segoe UI", 12F);
            lblTipoTrans.Location = new Point(40, 34);
            lblTipoTrans.Name = "lblTipoTrans";
            lblTipoTrans.Size = new Size(128, 21);
            lblTipoTrans.TabIndex = 0;
            lblTipoTrans.Text = "Tipo Transacción:";
            // 
            // cmbTransaccion
            // 
            cmbTransaccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTransaccion.Font = new Font("Segoe UI", 12F);
            cmbTransaccion.FormattingEnabled = true;
            cmbTransaccion.Items.AddRange(new object[] { "Compras" });
            cmbTransaccion.Location = new Point(174, 34);
            cmbTransaccion.Name = "cmbTransaccion";
            cmbTransaccion.Size = new Size(176, 29);
            cmbTransaccion.TabIndex = 1;
            // 
            // lblNumIngreso
            // 
            lblNumIngreso.AutoSize = true;
            lblNumIngreso.Font = new Font("Segoe UI", 12F);
            lblNumIngreso.Location = new Point(16, 88);
            lblNumIngreso.Name = "lblNumIngreso";
            lblNumIngreso.Size = new Size(152, 21);
            lblNumIngreso.TabIndex = 0;
            lblNumIngreso.Text = "Número de Ingreso: ";
            // 
            // txtIngreso
            // 
            txtIngreso.Font = new Font("Segoe UI", 12F);
            txtIngreso.Location = new Point(174, 88);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(176, 29);
            txtIngreso.TabIndex = 3;
            // 
            // txtCompra
            // 
            txtCompra.Font = new Font("Segoe UI", 12F);
            txtCompra.Location = new Point(174, 147);
            txtCompra.Name = "txtCompra";
            txtCompra.Size = new Size(176, 29);
            txtCompra.TabIndex = 5;
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Font = new Font("Segoe UI", 12F);
            lblFechaCompra.Location = new Point(37, 147);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(131, 21);
            lblFechaCompra.TabIndex = 0;
            lblFechaCompra.Text = "Fecha de compra:";
            // 
            // txtJuridica
            // 
            txtJuridica.Font = new Font("Segoe UI", 12F);
            txtJuridica.Location = new Point(174, 198);
            txtJuridica.Name = "txtJuridica";
            txtJuridica.Size = new Size(176, 29);
            txtJuridica.TabIndex = 7;
            // 
            // lblIDjuridica
            // 
            lblIDjuridica.AutoSize = true;
            lblIDjuridica.Font = new Font("Segoe UI", 12F);
            lblIDjuridica.Location = new Point(50, 198);
            lblIDjuridica.Name = "lblIDjuridica";
            lblIDjuridica.Size = new Size(118, 21);
            lblIDjuridica.TabIndex = 0;
            lblIDjuridica.Text = "Cédula Jurídica:";
            // 
            // cmbProductos
            // 
            cmbProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProductos.Font = new Font("Segoe UI", 12F);
            cmbProductos.FormattingEnabled = true;
            cmbProductos.Location = new Point(532, 34);
            cmbProductos.Name = "cmbProductos";
            cmbProductos.Size = new Size(176, 29);
            cmbProductos.TabIndex = 9;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 12F);
            lblProductos.Location = new Point(382, 34);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(144, 21);
            lblProductos.TabIndex = 0;
            lblProductos.Text = "Lista de productos: ";
            // 
            // txtNoProducto
            // 
            txtNoProducto.Font = new Font("Segoe UI", 12F);
            txtNoProducto.Location = new Point(532, 96);
            txtNoProducto.Name = "txtNoProducto";
            txtNoProducto.Size = new Size(176, 29);
            txtNoProducto.TabIndex = 11;
            // 
            // lblNoProducto
            // 
            lblNoProducto.AutoSize = true;
            lblNoProducto.Font = new Font("Segoe UI", 12F);
            lblNoProducto.Location = new Point(421, 96);
            lblNoProducto.Name = "lblNoProducto";
            lblNoProducto.Size = new Size(105, 21);
            lblNoProducto.TabIndex = 0;
            lblNoProducto.Text = "No Producto: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(532, 153);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(176, 29);
            txtCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F);
            lblCantidad.Location = new Point(447, 153);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(79, 21);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad: ";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(532, 211);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 34);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // uscCompra_Proveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAceptar);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(txtNoProducto);
            Controls.Add(lblNoProducto);
            Controls.Add(cmbProductos);
            Controls.Add(lblProductos);
            Controls.Add(txtJuridica);
            Controls.Add(lblIDjuridica);
            Controls.Add(txtCompra);
            Controls.Add(lblFechaCompra);
            Controls.Add(txtIngreso);
            Controls.Add(lblNumIngreso);
            Controls.Add(cmbTransaccion);
            Controls.Add(lblTipoTrans);
            Name = "uscCompra_Proveedor";
            Size = new Size(822, 514);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoTrans;
        private ComboBox cmbTransaccion;
        private Label lblNumIngreso;
        private TextBox txtIngreso;
        private TextBox txtCompra;
        private Label lblFechaCompra;
        private TextBox txtJuridica;
        private Label lblIDjuridica;
        private ComboBox cmbProductos;
        private Label lblProductos;
        private TextBox txtNoProducto;
        private Label lblNoProducto;
        private TextBox txtCantidad;
        private Label lblCantidad;
        private Button btnAceptar;
    }
}
