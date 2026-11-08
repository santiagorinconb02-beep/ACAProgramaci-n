namespace ACAProgramacion
{
    partial class FrmPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlTitulo = new Panel();
            lbnTitulo = new Label();
            lbnDevolucion = new Label();
            lbnPrestamo = new Label();
            lbnLibro = new Label();
            pnlBotones = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvPrestamos = new DataGridView();
            lbnU = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cmbLibro = new ComboBox();
            cmbUsuario = new ComboBox();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            PnlTitulo.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.Purple;
            PnlTitulo.Controls.Add(lbnTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1350, 60);
            PnlTitulo.TabIndex = 6;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.White;
            lbnTitulo.Location = new Point(519, 7);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(482, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "GESTIÓN DE PRÉSTAMOS";
            // 
            // lbnDevolucion
            // 
            lbnDevolucion.AutoSize = true;
            lbnDevolucion.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnDevolucion.Location = new Point(431, 294);
            lbnDevolucion.Name = "lbnDevolucion";
            lbnDevolucion.Size = new Size(191, 28);
            lbnDevolucion.TabIndex = 42;
            lbnDevolucion.Text = "Fecha Devolución:";
            // 
            // lbnPrestamo
            // 
            lbnPrestamo.AutoSize = true;
            lbnPrestamo.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnPrestamo.Location = new Point(431, 253);
            lbnPrestamo.Name = "lbnPrestamo";
            lbnPrestamo.Size = new Size(203, 28);
            lbnPrestamo.TabIndex = 43;
            lbnPrestamo.Text = "Fecha de Préstamo:";
            // 
            // lbnLibro
            // 
            lbnLibro.AutoSize = true;
            lbnLibro.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnLibro.Location = new Point(431, 210);
            lbnLibro.Name = "lbnLibro";
            lbnLibro.Size = new Size(70, 28);
            lbnLibro.TabIndex = 44;
            lbnLibro.Text = "Libro:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(286, 365);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(841, 60);
            pnlBotones.TabIndex = 45;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(176, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(689, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(149, 40);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 25;
            btnEliminar.Location = new Point(516, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(149, 40);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEditar.IconSize = 25;
            btnEditar.Location = new Point(352, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(149, 40);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.NairaSign;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnNuevo.IconSize = 25;
            btnNuevo.Location = new Point(3, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(149, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(103, 447);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(1100, 260);
            dgvPrestamos.TabIndex = 46;
            dgvPrestamos.CellDoubleClick += dgvPrestamos_CellDoubleClick;
            // 
            // lbnU
            // 
            lbnU.AutoSize = true;
            lbnU.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnU.Location = new Point(431, 170);
            lbnU.Name = "lbnU";
            lbnU.Size = new Size(95, 28);
            lbnU.TabIndex = 47;
            lbnU.Text = "Usuario:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(710, 215);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(300, 23);
            cmbLibro.TabIndex = 49;
            // 
            // cmbUsuario
            // 
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(710, 175);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(300, 23);
            cmbUsuario.TabIndex = 50;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(710, 299);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(300, 23);
            dtpFechaDevolucion.TabIndex = 52;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(710, 258);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(300, 23);
            dtpFechaPrestamo.TabIndex = 53;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(cmbUsuario);
            Controls.Add(cmbLibro);
            Controls.Add(lbnU);
            Controls.Add(dgvPrestamos);
            Controls.Add(pnlBotones);
            Controls.Add(lbnLibro);
            Controls.Add(lbnPrestamo);
            Controls.Add(lbnDevolucion);
            Controls.Add(PnlTitulo);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitulo;
        private Label lbnTitulo;
        private TextBox txtNombre;
        private TextBox textBox2;
        private Label label2;
        private ComboBox cmbAutor;
        private Label lbnDevolucion;
        private Label lbnPrestamo;
        private Label lbnLibro;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvPrestamos;
        private Label lbnU;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cmbLibro;
        private ComboBox cmbUsuario;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaPrestamo;
    }
}