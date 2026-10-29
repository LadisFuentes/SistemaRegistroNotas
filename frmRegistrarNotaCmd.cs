
using System;
using System.Globalization;
using System.Windows.Forms;
using SistemaRegistroNotas.Clases;
using SistemaRegistroNotas.Repositorios;

namespace SistemaRegistroNotas
{
    public partial class Form2 : Form
    {
        private readonly EstudianteRepositorio repositorio =
            new EstudianteRepositorio();

        private Estudiante estudianteActual;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Estudiante estudiante) : this()
        {
            if (estudiante == null)
                throw new ArgumentNullException(nameof(estudiante));

            estudianteActual = estudiante;

            txtNombre.Text = estudiante.Nombre;
            txtApellido.Text = estudiante.Apellido;
            txtCodigo.Text = estudiante.Codigo;
            txtLaboratorio.Text =
                estudiante.Laboratorio.ToString("0.00");
            txtParcial.Text =
                estudiante.Parcial.ToString("0.00");
            txtAsistencia.Text =
                estudiante.Asistencia.ToString("0.00");
        }

        private void lblAsistencia_Click(object sender, EventArgs e)
        {
            // Evento de la etiqueta Asistencia.
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

        private void btnGuardarCambios_Click(
            object sender, EventArgs e)
        {
            if (estudianteActual == null)
            {
                MessageBox.Show(
                    "No se recibió el estudiante que se desea editar.");
                return;
            }

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

            if (!LeerNota(
                txtLaboratorio, "Laboratorio", out laboratorio))
                return;

            if (!LeerNota(
                txtParcial, "Parcial", out parcial))
                return;

            if (!LeerNota(
                txtAsistencia, "Asistencia", out asistencia))
                return;

            estudianteActual.Nombre = txtNombre.Text.Trim();
            estudianteActual.Apellido = txtApellido.Text.Trim();
            estudianteActual.Codigo = txtCodigo.Text.Trim();
            estudianteActual.Laboratorio = laboratorio;
            estudianteActual.Parcial = parcial;
            estudianteActual.Asistencia = asistencia;

            estudianteActual.NotaFinal = Math.Round(
                laboratorio * 0.50m +
                parcial * 0.40m +
                asistencia * 0.10m, 2);

            try
            {
                repositorio.Actualizar(estudianteActual);

                MessageBox.Show(
                    "Los cambios se guardaron correctamente.\n" +
                    "Nota final: " +
                    estudianteActual.NotaFinal.ToString("0.00"),
                    "Actualización exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron guardar los cambios.\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
