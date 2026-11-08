namespace ACAProgramacion
{
    partial class FrmAutores
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
            lbnNombre = new Label();
            lbnApellido = new Label();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            pnlBotones = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvAutores = new DataGridView();
            PnlTitulo.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAutores).BeginInit();
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
            PnlTitulo.TabIndex = 4;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.White;
            lbnTitulo.Location = new Point(519, 7);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(427, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "GESTIÓN DE AUTORES";
            // 
            // lbnNombre
            // 
            lbnNombre.AutoSize = true;
            lbnNombre.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnNombre.Location = new Point(325, 190);
            lbnNombre.Name = "lbnNombre";
            lbnNombre.Size = new Size(135, 37);
            lbnNombre.TabIndex = 19;
            lbnNombre.Text = "Nombre:";
            // 
            // lbnApellido
            // 
            lbnApellido.AutoSize = true;
            lbnApellido.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnApellido.Location = new Point(324, 259);
            lbnApellido.Name = "lbnApellido";
            lbnApellido.Size = new Size(136, 37);
            lbnApellido.TabIndex = 20;
            lbnApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(490, 274);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(300, 23);
            txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(490, 204);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 23);
            txtNombre.TabIndex = 30;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(228, 400);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(1067, 60);
            pnlBotones.TabIndex = 31;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 25;
            btnGuardar.Location = new Point(206, 12);
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
            btnCancelar.Location = new Point(833, 12);
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
            btnEliminar.Location = new Point(626, 12);
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
            btnEditar.Location = new Point(413, 12);
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
            // dgvAutores
            // 
            dgvAutores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAutores.Location = new Point(213, 466);
            dgvAutores.Name = "dgvAutores";
            dgvAutores.Size = new Size(1100, 260);
            dgvAutores.TabIndex = 32;
            dgvAutores.CellDoubleClick += dgvAutores_CellDoubleClick;
            // 
            // FrmAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvAutores);
            Controls.Add(pnlBotones);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(lbnApellido);
            Controls.Add(lbnNombre);
            Controls.Add(PnlTitulo);
            Name = "FrmAutores";
            Text = "FrmAutores";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAutores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitulo;
        private Label lbnTitulo;
        private Label lbnNombre;
        private Label lbnApellido;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvAutores;
    }
}