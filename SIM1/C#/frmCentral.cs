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
            uscIngreso_Mantenimiento obj_IM = new uscIngreso_Mantenimiento();
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
    }
}
