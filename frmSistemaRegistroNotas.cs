
using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaRegistroNotas.Clases;
using SistemaRegistroNotas.Repositorios;

namespace SistemaRegistroNotas
{
    public partial class frmRegistarNota : Form
    {
        private readonly EstudianteRepositorio repositorio =
            new EstudianteRepositorio();

        public frmRegistarNota()
        {
            InitializeComponent();
            CargarEstudiantes();
        }

        private bool LeerNota(
            TextBox campo, string nombre, out decimal nota)
        {
            string valor = campo.Text.Trim().Replace(',', '.');

            if (!decimal.TryParse(
                    valor,
                    NumberStyles.Number,
                    CultureInfo.InvariantCulture,
                    out nota) ||
                nota < 0 || nota > 10)
            {
                MessageBox.Show(
                    nombre + " debe ser un número entre 0 y 10.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                campo.Focus();
                return false;
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show(
                    "Completa el nombre, apellido y código.");
                return;
            }

            decimal laboratorio;
            decimal parcial;
            decimal asistencia;

            if (!LeerNota(txtLaboratorio, "Laboratorio", out laboratorio))
                return;

            if (!LeerNota(txtParcial, "Parcial", out parcial))
                return;

            if (!LeerNota(txtAsistencia, "Asistencia", out asistencia))
                return;

            Estudiante estudiante = new Estudiante
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Codigo = txtCodigo.Text.Trim(),
                Laboratorio = laboratorio,
                Parcial = parcial,
                Asistencia = asistencia,
                NotaFinal = Math.Round(
                    laboratorio * 0.50m +
                    parcial * 0.40m +
                    asistencia * 0.10m, 2)
            };

            try
            {
                repositorio.Agregar(estudiante);

                MessageBox.Show(
                    "Estudiante registrado correctamente.\n" +
                    "Nota final: " +
                    estudiante.NotaFinal.ToString("0.00"),
                    "Registro exitoso");

                txtNombre.Clear();
                txtApellido.Clear();
                txtCodigo.Clear();
                txtLaboratorio.Clear();
                txtParcial.Clear();
                txtAsistencia.Clear();

                CargarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo registrar el estudiante.\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEstudiantes()
        {
            try
            {
                dgvRegistro.DataSource = null;
                dgvRegistro.DataSource = repositorio.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los estudiantes.\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
