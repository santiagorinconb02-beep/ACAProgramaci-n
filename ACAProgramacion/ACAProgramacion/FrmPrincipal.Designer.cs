namespace ACAProgramacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlMenu = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            btnReportes = new FontAwesome.Sharp.IconButton();
            btnPrestamos = new FontAwesome.Sharp.IconButton();
            btneditoriales = new FontAwesome.Sharp.IconButton();
            btnautores = new FontAwesome.Sharp.IconButton();
            btnusuarios = new FontAwesome.Sharp.IconButton();
            btnlibros = new FontAwesome.Sharp.IconButton();
            btninicio = new FontAwesome.Sharp.IconButton();
            pnlLogo = new Panel();
            picLogo = new PictureBox();
            lblSubtitulos = new Label();
            lblTitulo = new Label();
            pnlSuperior = new Panel();
            pnlEstado = new Panel();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(549, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(268, 21);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Black;
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnPrestamos);
            pnlMenu.Controls.Add(btneditoriales);
            pnlMenu.Controls.Add(btnautores);
            pnlMenu.Controls.Add(btnusuarios);
            pnlMenu.Controls.Add(btnlibros);
            pnlMenu.Controls.Add(btninicio);
            pnlMenu.Controls.Add(pnlLogo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(302, 611);
            pnlMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.AutoSize = true;
            btnSalir.BackColor = Color.White;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnSalir.IconColor = Color.Black;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 25;
            btnSalir.Location = new Point(0, 395);
            btnSalir.Margin = new Padding(0, 10, 0, 10);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(302, 45);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnReportes
            // 
            btnReportes.AutoSize = true;
            btnReportes.BackColor = Color.White;
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.IconChar = FontAwesome.Sharp.IconChar.Rust;
            btnReportes.IconColor = Color.Black;
            btnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReportes.IconSize = 25;
            btnReportes.Location = new Point(0, 350);
            btnReportes.Margin = new Padding(0, 10, 0, 10);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(302, 45);
            btnReportes.TabIndex = 7;
            btnReportes.Text = "Reportes";
            btnReportes.TextAlign = ContentAlignment.MiddleLeft;
            btnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnPrestamos
            // 
            btnPrestamos.AutoSize = true;
            btnPrestamos.BackColor = Color.White;
            btnPrestamos.Dock = DockStyle.Top;
            btnPrestamos.FlatAppearance.BorderSize = 0;
            btnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrestamos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnPrestamos.IconColor = Color.Black;
            btnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPrestamos.IconSize = 25;
            btnPrestamos.Location = new Point(0, 305);
            btnPrestamos.Margin = new Padding(0, 10, 0, 10);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(302, 45);
            btnPrestamos.TabIndex = 6;
            btnPrestamos.Text = "Prestamos";
            btnPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            btnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPrestamos.UseVisualStyleBackColor = false;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btneditoriales
            // 
            btneditoriales.AutoSize = true;
            btneditoriales.BackColor = Color.White;
            btneditoriales.Dock = DockStyle.Top;
            btneditoriales.FlatAppearance.BorderSize = 0;
            btneditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            btneditoriales.IconColor = Color.Black;
            btneditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btneditoriales.IconSize = 25;
            btneditoriales.Location = new Point(0, 260);
            btneditoriales.Margin = new Padding(0, 10, 0, 10);
            btneditoriales.Name = "btneditoriales";
            btneditoriales.Size = new Size(302, 45);
            btneditoriales.TabIndex = 5;
            btneditoriales.Text = "Editoriales";
            btneditoriales.TextAlign = ContentAlignment.MiddleLeft;
            btneditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btneditoriales.UseVisualStyleBackColor = false;
            btneditoriales.Click += btneditoriales_Click;
            // 
            // btnautores
            // 
            btnautores.AutoSize = true;
            btnautores.BackColor = Color.White;
            btnautores.Dock = DockStyle.Top;
            btnautores.FlatAppearance.BorderSize = 0;
            btnautores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnautores.IconChar = FontAwesome.Sharp.IconChar.BookReader;
            btnautores.IconColor = Color.Black;
            btnautores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnautores.IconSize = 25;
            btnautores.Location = new Point(0, 215);
            btnautores.Margin = new Padding(0, 10, 0, 10);
            btnautores.Name = "btnautores";
            btnautores.Size = new Size(302, 45);
            btnautores.TabIndex = 4;
            btnautores.Text = "Autores";
            btnautores.TextAlign = ContentAlignment.MiddleLeft;
            btnautores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnautores.UseVisualStyleBackColor = false;
            btnautores.Click += btnautores_Click;
            // 
            // btnusuarios
            // 
            btnusuarios.AutoSize = true;
            btnusuarios.BackColor = Color.White;
            btnusuarios.Dock = DockStyle.Top;
            btnusuarios.FlatAppearance.BorderSize = 0;
            btnusuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnusuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnusuarios.IconColor = Color.Black;
            btnusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnusuarios.IconSize = 25;
            btnusuarios.Location = new Point(0, 170);
            btnusuarios.Margin = new Padding(0, 10, 0, 10);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(302, 45);
            btnusuarios.TabIndex = 3;
            btnusuarios.Text = "Usuarios";
            btnusuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnusuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnusuarios.UseVisualStyleBackColor = false;
            btnusuarios.Click += btnusuarios_Click;
            // 
            // btnlibros
            // 
            btnlibros.AutoSize = true;
            btnlibros.BackColor = Color.White;
            btnlibros.Cursor = Cursors.Hand;
            btnlibros.Dock = DockStyle.Top;
            btnlibros.FlatAppearance.BorderSize = 0;
            btnlibros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            btnlibros.IconColor = Color.Black;
            btnlibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnlibros.IconSize = 25;
            btnlibros.Location = new Point(0, 125);
            btnlibros.Margin = new Padding(0, 10, 0, 10);
            btnlibros.Name = "btnlibros";
            btnlibros.Size = new Size(302, 45);
            btnlibros.TabIndex = 2;
            btnlibros.Text = "Libros";
            btnlibros.TextAlign = ContentAlignment.MiddleLeft;
            btnlibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlibros.UseVisualStyleBackColor = false;
            btnlibros.Click += btnlibros_Click;
            // 
            // btninicio
            // 
            btninicio.AutoSize = true;
            btninicio.BackColor = Color.White;
            btninicio.Dock = DockStyle.Top;
            btninicio.FlatAppearance.BorderSize = 0;
            btninicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninicio.IconChar = FontAwesome.Sharp.IconChar.House;
            btninicio.IconColor = Color.Black;
            btninicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btninicio.IconSize = 25;
            btninicio.Location = new Point(0, 80);
            btninicio.Margin = new Padding(0, 10, 0, 10);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(302, 45);
            btninicio.TabIndex = 1;
            btninicio.Text = "Inicio";
            btninicio.TextAlign = ContentAlignment.MiddleLeft;
            btninicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btninicio.UseVisualStyleBackColor = false;
            btninicio.Click += btninicio_Click;
            // 
            // pnlLogo
            // 
            pnlLogo.BackColor = Color.Purple;
            pnlLogo.Controls.Add(picLogo);
            pnlLogo.Controls.Add(lblSubtitulos);
            pnlLogo.Controls.Add(lblTitulo);
            pnlLogo.Dock = DockStyle.Top;
            pnlLogo.Location = new Point(0, 0);
            pnlLogo.Name = "pnlLogo";
            pnlLogo.Size = new Size(302, 80);
            pnlLogo.TabIndex = 0;
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(-41, -11);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(177, 112);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtitulos
            // 
            lblSubtitulos.AutoSize = true;
            lblSubtitulos.BackColor = Color.Purple;
            lblSubtitulos.Font = new Font("Edwardian Script ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulos.ForeColor = SystemColors.ButtonHighlight;
            lblSubtitulos.Location = new Point(142, 50);
            lblSubtitulos.Name = "lblSubtitulos";
            lblSubtitulos.Size = new Size(126, 19);
            lblSubtitulos.TabIndex = 1;
            lblSubtitulos.Text = "Sistema De Gestión";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Curlz MT", 23F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonFace;
            lblTitulo.Location = new Point(142, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(142, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Biblioteca";
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = SystemColors.ActiveBorder;
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(302, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1062, 80);
            pnlSuperior.TabIndex = 2;
            // 
            // pnlEstado
            // 
            pnlEstado.BackColor = Color.Silver;
            pnlEstado.Dock = DockStyle.Bottom;
            pnlEstado.Location = new Point(302, 576);
            pnlEstado.Name = "pnlEstado";
            pnlEstado.Size = new Size(1062, 35);
            pnlEstado.TabIndex = 3;
            // 
            // pnlContenido
            // 
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(302, 80);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1062, 496);
            pnlContenido.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 611);
            Controls.Add(pnlContenido);
            Controls.Add(pnlEstado);
            Controls.Add(pnlSuperior);
            Controls.Add(pnlMenu);
            Controls.Add(flowLayoutPanel1);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sitema Gestión De Biblioteca";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlLogo.ResumeLayout(false);
            pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlMenu;
        private Panel pnlSuperior;
        private Panel pnlEstado;
        private Panel pnlContenido;
        private Panel pnlLogo;
        private Label lblTitulo;
        private Label lblSubtitulos;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btninicio;
        private FontAwesome.Sharp.IconButton btnlibros;
        private FontAwesome.Sharp.IconButton btnautores;
        private FontAwesome.Sharp.IconButton btnusuarios;
        private FontAwesome.Sharp.IconButton btnPrestamos;
        private FontAwesome.Sharp.IconButton btneditoriales;
        private FontAwesome.Sharp.IconButton btnReportes;
        private FontAwesome.Sharp.IconButton btnSalir;
    }
}
