namespace ACAProgramacion
{
    partial class FrmUsuarios
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
            txtN = new TextBox();
            txtA = new TextBox();
            txtC = new TextBox();
            lbnNombre = new Label();
            lbnApellido = new Label();
            pnlBotones = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvUsuarios = new DataGridView();
            lbnDocumento = new Label();
            lbnTelefono = new Label();
            lbnCorreo = new Label();
            txtD = new TextBox();
            txtTelefono = new TextBox();
            PnlTitulo.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            PnlTitulo.TabIndex = 3;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.White;
            lbnTitulo.Location = new Point(519, 7);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(445, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // txtN
            // 
            txtN.Location = new Point(534, 126);
            txtN.Name = "txtN";
            txtN.Size = new Size(320, 23);
            txtN.TabIndex = 13;
            // 
            // txtA
            // 
            txtA.Location = new Point(534, 170);
            txtA.Name = "txtA";
            txtA.Size = new Size(320, 23);
            txtA.TabIndex = 15;
            // 
            // txtC
            // 
            txtC.Location = new Point(534, 303);
            txtC.Name = "txtC";
            txtC.Size = new Size(320, 23);
            txtC.TabIndex = 17;
            // 
            // lbnNombre
            // 
            lbnNombre.AutoSize = true;
            lbnNombre.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnNombre.Location = new Point(403, 132);
            lbnNombre.Name = "lbnNombre";
            lbnNombre.Size = new Size(64, 17);
            lbnNombre.TabIndex = 18;
            lbnNombre.Text = "Nombre:";
            // 
            // lbnApellido
            // 
            lbnApellido.AutoSize = true;
            lbnApellido.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnApellido.Location = new Point(403, 176);
            lbnApellido.Name = "lbnApellido";
            lbnApellido.Size = new Size(65, 17);
            lbnApellido.TabIndex = 22;
            lbnApellido.Text = "Apellido:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(266, 366);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(841, 60);
            pnlBotones.TabIndex = 23;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(186, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(149, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCancelar.IconSize = 25;
            btnCancelar.Location = new Point(680, 12);
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
            btnNuevo.Location = new Point(19, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(149, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(142, 432);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(1100, 260);
            dgvUsuarios.TabIndex = 24;
            dgvUsuarios.CellContentDoubleClick += dgvUsuarios_CellContentDoubleClick;
            // 
            // lbnDocumento
            // 
            lbnDocumento.AutoSize = true;
            lbnDocumento.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnDocumento.Location = new Point(403, 220);
            lbnDocumento.Name = "lbnDocumento";
            lbnDocumento.Size = new Size(84, 17);
            lbnDocumento.TabIndex = 25;
            lbnDocumento.Text = "Documento:";
            // 
            // lbnTelefono
            // 
            lbnTelefono.AutoSize = true;
            lbnTelefono.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnTelefono.Location = new Point(403, 265);
            lbnTelefono.Name = "lbnTelefono";
            lbnTelefono.Size = new Size(68, 17);
            lbnTelefono.TabIndex = 26;
            lbnTelefono.Text = "Teléfono:";
            // 
            // lbnCorreo
            // 
            lbnCorreo.AutoSize = true;
            lbnCorreo.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnCorreo.Location = new Point(403, 309);
            lbnCorreo.Name = "lbnCorreo";
            lbnCorreo.Size = new Size(55, 17);
            lbnCorreo.TabIndex = 27;
            lbnCorreo.Text = "Correo:";
            // 
            // txtD
            // 
            txtD.Location = new Point(534, 214);
            txtD.Name = "txtD";
            txtD.Size = new Size(320, 23);
            txtD.TabIndex = 28;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(534, 264);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(320, 23);
            txtTelefono.TabIndex = 29;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(txtTelefono);
            Controls.Add(txtD);
            Controls.Add(lbnCorreo);
            Controls.Add(lbnTelefono);
            Controls.Add(lbnDocumento);
            Controls.Add(dgvUsuarios);
            Controls.Add(pnlBotones);
            Controls.Add(lbnApellido);
            Controls.Add(lbnNombre);
            Controls.Add(txtC);
            Controls.Add(txtA);
            Controls.Add(txtN);
            Controls.Add(PnlTitulo);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel PnlTitulo;
        private Label lbnTitulo;
        private TextBox txtN;
        private TextBox textBox1;
        private TextBox txtA;
        private TextBox textBox3;
        private TextBox txtC;
        private Label lbnNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbnApellido;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvUsuarios;
        private Label lbnDocumento;
        private Label lbnTelefono;
        private Label lbnCorreo;
        private TextBox txtD;
        private TextBox txtTelefono;
    }
}