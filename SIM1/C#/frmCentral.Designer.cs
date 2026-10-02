namespace Sistema_de_Ventas_y_Distribución
{
    partial class frmCentral
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mspGeneral = new MenuStrip();
            opcion1ToolStripMenuItem = new ToolStripMenuItem();
            comprasToolStripMenuItem = new ToolStripMenuItem();
            ingresoYMantenimientoToolStripMenuItem = new ToolStripMenuItem();
            pnlGeneral = new Panel();
            mspGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // mspGeneral
            // 
            mspGeneral.Items.AddRange(new ToolStripItem[] { opcion1ToolStripMenuItem, comprasToolStripMenuItem, ingresoYMantenimientoToolStripMenuItem });
            mspGeneral.Location = new Point(0, 0);
            mspGeneral.Name = "mspGeneral";
            mspGeneral.Size = new Size(844, 24);
            mspGeneral.TabIndex = 0;
            mspGeneral.Text = "menuStrip1";
            // 
            // opcion1ToolStripMenuItem
            // 
            opcion1ToolStripMenuItem.Name = "opcion1ToolStripMenuItem";
            opcion1ToolStripMenuItem.Size = new Size(162, 20);
            opcion1ToolStripMenuItem.Text = "Mantenimiento de Clientes";
            opcion1ToolStripMenuItem.Click += opcion1ToolStripMenuItem_Click;
            // 
            // comprasToolStripMenuItem
            // 
            comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            comprasToolStripMenuItem.Size = new Size(67, 20);
            comprasToolStripMenuItem.Text = "Compras";
            comprasToolStripMenuItem.Click += comprasToolStripMenuItem_Click;
            // 
            // ingresoYMantenimientoToolStripMenuItem
            // 
            ingresoYMantenimientoToolStripMenuItem.Name = "ingresoYMantenimientoToolStripMenuItem";
            ingresoYMantenimientoToolStripMenuItem.Size = new Size(152, 20);
            ingresoYMantenimientoToolStripMenuItem.Text = "Ingreso y Mantenimiento";
            ingresoYMantenimientoToolStripMenuItem.Click += ingresoYMantenimientoToolStripMenuItem_Click;
            // 
            // pnlGeneral
            // 
            pnlGeneral.Location = new Point(0, 27);
            pnlGeneral.Name = "pnlGeneral";
            pnlGeneral.Size = new Size(832, 451);
            pnlGeneral.TabIndex = 1;
            // 
            // frmCentral
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 490);
            Controls.Add(pnlGeneral);
            Controls.Add(mspGeneral);
            MainMenuStrip = mspGeneral;
            Name = "frmCentral";
            Text = "Form1";
            mspGeneral.ResumeLayout(false);
            mspGeneral.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mspGeneral;
        private ToolStripMenuItem opcion1ToolStripMenuItem;
        private ToolStripMenuItem comprasToolStripMenuItem;
        private ToolStripMenuItem ingresoYMantenimientoToolStripMenuItem;
        private Panel pnlGeneral;
    }
}
