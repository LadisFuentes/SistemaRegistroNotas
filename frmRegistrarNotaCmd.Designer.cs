
namespace SistemaRegistroNotas
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvRegistro = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAsistencia = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtLaboratorio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblParcial = new System.Windows.Forms.Label();
            this.lblLaboratorio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).BeginInit();
            this.SuspendLayout();

            // dgvRegistro
            this.dgvRegistro.AllowUserToDeleteRows = false;
            this.dgvRegistro.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistro.Location = new System.Drawing.Point(80, 269);
            this.dgvRegistro.MultiSelect = false;
            this.dgvRegistro.Name = "dgvRegistro";
            this.dgvRegistro.ReadOnly = true;
            this.dgvRegistro.RowHeadersWidth = 62;
            this.dgvRegistro.RowTemplate.Height = 28;
            this.dgvRegistro.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistro.Size = new System.Drawing.Size(640, 150);
            this.dgvRegistro.TabIndex = 26;

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(42, 185);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 58);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Guardar cambios";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click +=
                new System.EventHandler(this.btnGuardarCambios_Click);

            // txtAsistencia
            this.txtAsistencia.Location = new System.Drawing.Point(529, 136);
            this.txtAsistencia.Name = "txtAsistencia";
            this.txtAsistencia.Size = new System.Drawing.Size(234, 26);
            this.txtAsistencia.TabIndex = 24;

            // txtParcial
            this.txtParcial.Location = new System.Drawing.Point(529, 81);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(234, 26);
            this.txtParcial.TabIndex = 23;

            // txtLaboratorio
            this.txtLaboratorio.Location = new System.Drawing.Point(529, 38);
            this.txtLaboratorio.Name = "txtLaboratorio";
            this.txtLaboratorio.Size = new System.Drawing.Size(234, 26);
            this.txtLaboratorio.TabIndex = 22;

            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(148, 136);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(234, 26);
            this.txtCodigo.TabIndex = 21;

            // txtApellido
            this.txtApellido.Location = new System.Drawing.Point(148, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(234, 26);
            this.txtApellido.TabIndex = 20;

            // lblAsistencia
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Location = new System.Drawing.Point(419, 142);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(82, 20);
            this.lblAsistencia.TabIndex = 19;
            this.lblAsistencia.Text = "Asistencia";
            this.lblAsistencia.Click +=
                new System.EventHandler(this.lblAsistencia_Click);

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(148, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 26);
            this.txtNombre.TabIndex = 18;

            // lblParcial
            this.lblParcial.AutoSize = true;
            this.lblParcial.Location = new System.Drawing.Point(419, 78);
            this.lblParcial.Name = "lblParcial";
            this.lblParcial.Size = new System.Drawing.Size(56, 20);
            this.lblParcial.TabIndex = 16;
            this.lblParcial.Text = "Parcial";

            // lblLaboratorio
            this.lblLaboratorio.AutoSize = true;
            this.lblLaboratorio.Location = new System.Drawing.Point(419, 38);
            this.lblLaboratorio.Name = "lblLaboratorio";
            this.lblLaboratorio.Size = new System.Drawing.Size(90, 20);
            this.lblLaboratorio.TabIndex = 17;
            this.lblLaboratorio.Text = "Laboratorio";

            // lblCodigo
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(42, 136);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 15;
            this.lblCodigo.Text = "Código";

            // lblApellido
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(38, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lblApellido.TabIndex = 14;
            this.lblApellido.Text = "Apellido";

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre";

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);

            this.Controls.Add(this.dgvRegistro);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtAsistencia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.txtLaboratorio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblAsistencia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblParcial);
            this.Controls.Add(this.lblLaboratorio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);

            this.Name = "Form2";
            this.Text = "Editar registro de notas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtLaboratorio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblParcial;
        private System.Windows.Forms.Label lblLaboratorio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
    }
}
