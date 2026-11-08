using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ACAProgramacion.Datos;

namespace ACAProgramacion
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Usuarios";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvUsuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text) ||
                string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtD.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de guardar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "INSERT INTO Usuarios " +
                    "(Nombre, Apellido, Documento, Telefono, Correo) " +
                    "VALUES " +
                    "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@Nombre", txtN.Text.Trim());
                    comando.Parameters.AddWithValue("@Apellido", txtA.Text.Trim());
                    comando.Parameters.AddWithValue("@Documento", txtD.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", txtTelefono.Text.Trim());
                    comando.Parameters.AddWithValue("@Correo", txtC.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario guardado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevo_Click(null, null);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtA.Clear();
            txtD.Clear();
            txtTelefono.Clear();
            txtC.Clear();

            txtN.Focus();
        }

        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtN.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            txtA.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

            txtD.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            txtTelefono.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            txtC.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            if (string.IsNullOrWhiteSpace(txtN.Text) ||
                string.IsNullOrWhiteSpace(txtA.Text) ||
                string.IsNullOrWhiteSpace(txtD.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtC.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "UPDATE Usuarios SET " +
                    "Nombre = @Nombre, " +
                    "Apellido = @Apellido, " +
                    "Documento = @Documento, " +
                    "Telefono = @Telefono, " +
                    "Correo = @Correo " +
                    "WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        txtN.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        txtA.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Documento",
                        txtD.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        txtTelefono.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        txtC.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@IdUsuario",
                        idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario actualizado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevo_Click(null, null);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
                "Biblioteca",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario eliminado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevo_Click(null, null);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            txtA.Clear();
            txtD.Clear();
            txtTelefono.Clear();
            txtC.Clear();

            dgvUsuarios.ClearSelection();

            txtN.Focus();
        }
    }
} 