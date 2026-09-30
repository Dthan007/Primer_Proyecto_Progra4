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
    }
}
