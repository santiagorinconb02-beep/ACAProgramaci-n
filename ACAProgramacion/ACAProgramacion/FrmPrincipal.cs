using ACAProgramacion.Datos;

namespace ACAProgramacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            Conexion conexion = new Conexion();
            try
            {
                using (var conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    // La conexión se ha abierto correctamente
                    MessageBox.Show("Conexión a la base de datos establecida correctamente.",
                        "ACAProgramacion",
                    MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
                    "ACAProgramacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            AbrirFormulario(new FrmInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            pnlContenido.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            pnlContenido.Controls.Add(formulario);
            formulario.Show();



        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmInicio());
        }

        private void btnlibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());

        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void btnautores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }

        private void btneditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgVLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
