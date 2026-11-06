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
            lbnBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            PnlDatos = new Panel();
            lbnISBN = new Label();
            lbnTituloLib = new Label();
            lbnAutor = new Label();
            lbnEditorial = new Label();
            lbnCategoria = new Label();
            lbnAño = new Label();
            lbnExistencias = new Label();
            txtISBN = new TextBox();
            txtTitulo = new TextBox();
            txtCategoria = new TextBox();
            txtAño = new TextBox();
            TxtExistencias = new TextBox();
            cmbAutor = new ComboBox();
            cmbEditorial = new ComboBox();
            PnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            PnlDatos.SuspendLayout();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.Silver;
            PnlTitulo.Controls.Add(lbnTitulo);
            PnlTitulo.Dock = DockStyle.Top;
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(880, 60);
            PnlTitulo.TabIndex = 0;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.Black;
            lbnTitulo.Location = new Point(222, 9);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(331, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "Gestión de Libros";
            lbnTitulo.Click += lbnTitulo_Click;
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
            pnlBusqueda.Size = new Size(880, 55);
            pnlBusqueda.TabIndex = 1;
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
            // txtBuscar
            // 
            txtBuscar.Location = new Point(100, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(284, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(390, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
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
            PnlDatos.Size = new Size(880, 274);
            PnlDatos.TabIndex = 2;
            // 
            // lbnISBN
            // 
            lbnISBN.AutoSize = true;
            lbnISBN.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnISBN.Location = new Point(56, 43);
            lbnISBN.Name = "lbnISBN";
            lbnISBN.Size = new Size(44, 17);
            lbnISBN.TabIndex = 1;
            lbnISBN.Text = "ISBN:";
            lbnISBN.Click += lbnISBN_Click;
            // 
            // lbnTituloLib
            // 
            lbnTituloLib.AutoSize = true;
            lbnTituloLib.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnTituloLib.Location = new Point(56, 72);
            lbnTituloLib.Name = "lbnTituloLib";
            lbnTituloLib.Size = new Size(49, 17);
            lbnTituloLib.TabIndex = 2;
            lbnTituloLib.Text = "Titulo:";
            // 
            // lbnAutor
            // 
            lbnAutor.AutoSize = true;
            lbnAutor.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnAutor.Location = new Point(56, 101);
            lbnAutor.Name = "lbnAutor";
            lbnAutor.Size = new Size(49, 17);
            lbnAutor.TabIndex = 3;
            lbnAutor.Text = "Autor:";
            // 
            // lbnEditorial
            // 
            lbnEditorial.AutoSize = true;
            lbnEditorial.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnEditorial.Location = new Point(56, 130);
            lbnEditorial.Name = "lbnEditorial";
            lbnEditorial.Size = new Size(65, 17);
            lbnEditorial.TabIndex = 4;
            lbnEditorial.Text = "Editorial:";
            // 
            // lbnCategoria
            // 
            lbnCategoria.AutoSize = true;
            lbnCategoria.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnCategoria.Location = new Point(56, 159);
            lbnCategoria.Name = "lbnCategoria";
            lbnCategoria.Size = new Size(72, 17);
            lbnCategoria.TabIndex = 5;
            lbnCategoria.Text = "Categoria:";
            // 
            // lbnAño
            // 
            lbnAño.AutoSize = true;
            lbnAño.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnAño.Location = new Point(56, 188);
            lbnAño.Name = "lbnAño";
            lbnAño.Size = new Size(38, 17);
            lbnAño.TabIndex = 6;
            lbnAño.Text = "Año:";
            // 
            // lbnExistencias
            // 
            lbnExistencias.AutoSize = true;
            lbnExistencias.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnExistencias.Location = new Point(56, 217);
            lbnExistencias.Name = "lbnExistencias";
            lbnExistencias.Size = new Size(80, 17);
            lbnExistencias.TabIndex = 7;
            lbnExistencias.Text = "Existencias:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(156, 37);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(228, 23);
            txtISBN.TabIndex = 8;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(156, 66);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(228, 23);
            txtTitulo.TabIndex = 9;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(156, 153);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(228, 23);
            txtCategoria.TabIndex = 10;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(156, 182);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(228, 23);
            txtAño.TabIndex = 11;
            // 
            // TxtExistencias
            // 
            TxtExistencias.Location = new Point(156, 211);
            TxtExistencias.Name = "TxtExistencias";
            TxtExistencias.Size = new Size(228, 23);
            TxtExistencias.TabIndex = 12;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(156, 95);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(228, 23);
            cmbAutor.TabIndex = 13;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(156, 124);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(228, 23);
            cmbEditorial.TabIndex = 14;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 496);
            Controls.Add(PnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(PnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            PnlDatos.ResumeLayout(false);
            PnlDatos.PerformLayout();
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
    }
}