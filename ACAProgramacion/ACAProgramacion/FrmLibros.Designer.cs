namespace ACAProgramacion
{
    partial class FrmLibros
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
            pnlBusqueda = new Panel();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            lbnBuscar = new Label();
            PnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            TxtExistencias = new TextBox();
            txtAño = new TextBox();
            txtCategoria = new TextBox();
            txtTitulo = new TextBox();
            txtISBN = new TextBox();
            lbnExistencias = new Label();
            lbnAño = new Label();
            lbnCategoria = new Label();
            lbnEditorial = new Label();
            lbnAutor = new Label();
            lbnTituloLib = new Label();
            lbnISBN = new Label();
            pnlBotones = new Panel();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgVLibros = new DataGridView();
            PnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgVLibros).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.Silver;
            PnlTitulo.Controls.Add(lbnTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(1350, 60);
            PnlTitulo.TabIndex = 0;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.Black;
            lbnTitulo.Location = new Point(519, 7);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(331, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "Gestión de Libros";
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = Color.Purple;
            pnlBusqueda.Controls.Add(btnBuscar);
            pnlBusqueda.Controls.Add(txtBuscar);
            pnlBusqueda.Controls.Add(lbnBuscar);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(390, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(100, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(284, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lbnBuscar
            // 
            lbnBuscar.AutoSize = true;
            lbnBuscar.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnBuscar.Location = new Point(56, 22);
            lbnBuscar.Name = "lbnBuscar";
            lbnBuscar.Size = new Size(40, 17);
            lbnBuscar.TabIndex = 0;
            lbnBuscar.Text = "ISBN";
            // 
            // PnlDatos
            // 
            PnlDatos.Controls.Add(cmbEditorial);
            PnlDatos.Controls.Add(cmbAutor);
            PnlDatos.Controls.Add(TxtExistencias);
            PnlDatos.Controls.Add(txtAño);
            PnlDatos.Controls.Add(txtCategoria);
            PnlDatos.Controls.Add(txtTitulo);
            PnlDatos.Controls.Add(txtISBN);
            PnlDatos.Controls.Add(lbnExistencias);
            PnlDatos.Controls.Add(lbnAño);
            PnlDatos.Controls.Add(lbnCategoria);
            PnlDatos.Controls.Add(lbnEditorial);
            PnlDatos.Controls.Add(lbnAutor);
            PnlDatos.Controls.Add(lbnTituloLib);
            PnlDatos.Controls.Add(lbnISBN);
            PnlDatos.Dock = DockStyle.Top;
            PnlDatos.Location = new Point(0, 115);
            PnlDatos.Name = "PnlDatos";
            PnlDatos.Size = new Size(1350, 274);
            PnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(156, 128);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(228, 23);
            cmbEditorial.TabIndex = 14;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(156, 99);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(228, 23);
            cmbAutor.TabIndex = 13;
            // 
            // TxtExistencias
            // 
            TxtExistencias.Location = new Point(156, 215);
            TxtExistencias.Name = "TxtExistencias";
            TxtExistencias.Size = new Size(228, 23);
            TxtExistencias.TabIndex = 12;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(156, 186);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(228, 23);
            txtAño.TabIndex = 11;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(156, 157);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(228, 23);
            txtCategoria.TabIndex = 10;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(156, 70);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(228, 23);
            txtTitulo.TabIndex = 9;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(156, 41);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(228, 23);
            txtISBN.TabIndex = 8;
            // 
            // lbnExistencias
            // 
            lbnExistencias.AutoSize = true;
            lbnExistencias.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnExistencias.Location = new Point(56, 221);
            lbnExistencias.Name = "lbnExistencias";
            lbnExistencias.Size = new Size(80, 17);
            lbnExistencias.TabIndex = 7;
            lbnExistencias.Text = "Existencias:";
            // 
            // lbnAño
            // 
            lbnAño.AutoSize = true;
            lbnAño.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnAño.Location = new Point(56, 192);
            lbnAño.Name = "lbnAño";
            lbnAño.Size = new Size(38, 17);
            lbnAño.TabIndex = 6;
            lbnAño.Text = "Año:";
            // 
            // lbnCategoria
            // 
            lbnCategoria.AutoSize = true;
            lbnCategoria.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnCategoria.Location = new Point(56, 163);
            lbnCategoria.Name = "lbnCategoria";
            lbnCategoria.Size = new Size(72, 17);
            lbnCategoria.TabIndex = 5;
            lbnCategoria.Text = "Categoria:";
            // 
            // lbnEditorial
            // 
            lbnEditorial.AutoSize = true;
            lbnEditorial.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnEditorial.Location = new Point(56, 134);
            lbnEditorial.Name = "lbnEditorial";
            lbnEditorial.Size = new Size(65, 17);
            lbnEditorial.TabIndex = 4;
            lbnEditorial.Text = "Editorial:";
            // 
            // lbnAutor
            // 
            lbnAutor.AutoSize = true;
            lbnAutor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnAutor.Location = new Point(56, 105);
            lbnAutor.Name = "lbnAutor";
            lbnAutor.Size = new Size(49, 17);
            lbnAutor.TabIndex = 3;
            lbnAutor.Text = "Autor:";
            // 
            // lbnTituloLib
            // 
            lbnTituloLib.AutoSize = true;
            lbnTituloLib.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnTituloLib.Location = new Point(56, 76);
            lbnTituloLib.Name = "lbnTituloLib";
            lbnTituloLib.Size = new Size(49, 17);
            lbnTituloLib.TabIndex = 2;
            lbnTituloLib.Text = "Titulo:";
            // 
            // lbnISBN
            // 
            lbnISBN.AutoSize = true;
            lbnISBN.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnISBN.Location = new Point(56, 47);
            lbnISBN.Name = "lbnISBN";
            lbnISBN.Size = new Size(44, 17);
            lbnISBN.TabIndex = 1;
            lbnISBN.Text = "ISBN:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(185, 395);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(841, 60);
            pnlBotones.TabIndex = 3;
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
            // dgVLibros
            // 
            dgVLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgVLibros.Location = new Point(46, 461);
            dgVLibros.Name = "dgVLibros";
            dgVLibros.Size = new Size(1100, 260);
            dgVLibros.TabIndex = 4;
            dgVLibros.CellDoubleClick += dgVLibros_CellDoubleClick;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgVLibros);
            Controls.Add(pnlBotones);
            Controls.Add(PnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(PnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgVLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PnlTitulo;
        private Label lbnTitulo;
        private Panel pnlBusqueda;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label lbnBuscar;
        private Panel PnlDatos;
        private Label lbnTituloLib;
        private Label lbnISBN;
        private Label lbnEditorial;
        private Label lbnAutor;
        private TextBox txtCategoria;
        private TextBox txtTitulo;
        private TextBox txtISBN;
        private Label lbnExistencias;
        private Label lbnAño;
        private Label lbnCategoria;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox TxtExistencias;
        private TextBox txtAño;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private DataGridView dgVLibros;
    }
}