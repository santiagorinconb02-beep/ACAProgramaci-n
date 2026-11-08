namespace ACAProgramacion
{
    partial class FrmEditoriales
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
            txtNombre = new TextBox();
            lbnNombre = new Label();
            pnlBotones = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvEditoriales = new DataGridView();
            PnlTitulo.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
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
            PnlTitulo.TabIndex = 5;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.White;
            lbnTitulo.Location = new Point(519, 7);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(495, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "GESTIÓN DE EDITORIALES";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(655, 195);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 23);
            txtNombre.TabIndex = 32;
            // 
            // lbnNombre
            // 
            lbnNombre.AutoSize = true;
            lbnNombre.Font = new Font("Segoe UI Black", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnNombre.Location = new Point(490, 181);
            lbnNombre.Name = "lbnNombre";
            lbnNombre.Size = new Size(135, 37);
            lbnNombre.TabIndex = 31;
            lbnNombre.Text = "Nombre:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(142, 334);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(1067, 60);
            pnlBotones.TabIndex = 33;
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
            // dgvEditoriales
            // 
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Location = new Point(123, 400);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(1100, 260);
            dgvEditoriales.TabIndex = 34;
            dgvEditoriales.CellContentDoubleClick += dgvEditoriales_CellContentDoubleClick;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlBotones);
            Controls.Add(txtNombre);
            Controls.Add(lbnNombre);
            Controls.Add(PnlTitulo);
            Name = "FrmEditoriales";
            Text = "FrmEditoriales";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitulo;
        private Label lbnTitulo;
        private TextBox txtNombre;
        private Label lbnNombre;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvEditoriales;
    }
}