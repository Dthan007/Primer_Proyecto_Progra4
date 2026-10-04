using Sistema_de_Ventas_y_Distribución.UserVentanas;

namespace Sistema_de_Ventas_y_Distribución
{
    public partial class frmCentral : Form
    {


        public frmCentral()
        {
            InitializeComponent();

        }

        private void ingresoYMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscIngreso_Producto obj_IM = new uscIngreso_Producto();
            obj_IM.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_IM);

        }

        private void opcion1ToolStripMenuItem_Click(object sender, EventArgs e)//mantenimientoClientesToolStripMenuItem
        {
            pnlGeneral.Controls.Clear();
            uscMantenimientoClientes obj_MC = new uscMantenimientoClientes();
            obj_MC.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_MC);
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscCompras obj_C = new uscCompras();
            obj_C.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_C);
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscIngreso_Proveedor obj_IP = new uscIngreso_Proveedor();
            obj_IP.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_IP);
        }

        private void compraProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlGeneral.Controls.Clear();
            uscCompra_Proveedor obj_CP = new uscCompra_Proveedor();
            obj_CP.Dock = DockStyle.Fill;
            pnlGeneral.Controls.Add(obj_CP);

        }
    }
}
