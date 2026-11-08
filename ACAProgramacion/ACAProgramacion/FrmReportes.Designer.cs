namespace ACAProgramacion
{
    partial class FrmReportes
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
            cmbTipoReporte = new ComboBox();
            lbnTipoReporte = new Label();
            pnlBotones = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnGenerarReporte = new FontAwesome.Sharp.IconButton();
            dgvReportes = new DataGridView();
            PnlTitulo.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
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
            PnlTitulo.TabIndex = 7;
            // 
            // lbnTitulo
            // 
            lbnTitulo.AutoSize = true;
            lbnTitulo.BackColor = Color.Transparent;
            lbnTitulo.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbnTitulo.ForeColor = Color.White;
            lbnTitulo.Location = new Point(519, 7);
            lbnTitulo.Name = "lbnTitulo";
            lbnTitulo.Size = new Size(443, 50);
            lbnTitulo.TabIndex = 0;
            lbnTitulo.Text = "GESTIÓN DE REPORTES";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(678, 173);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(300, 23);
            cmbTipoReporte.TabIndex = 52;
            // 
            // lbnTipoReporte
            // 
            lbnTipoReporte.AutoSize = true;
            lbnTipoReporte.Font = new Font("Segoe UI Black", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbnTipoReporte.Location = new Point(399, 168);
            lbnTipoReporte.Name = "lbnTipoReporte";
            lbnTipoReporte.Size = new Size(180, 28);
            lbnTipoReporte.TabIndex = 51;
            lbnTipoReporte.Text = "Tipo De Reporte:";
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnLimpiar);
            pnlBotones.Controls.Add(btnGenerarReporte);
            pnlBotones.Location = new Point(654, 228);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(337, 60);
            pnlBotones.TabIndex = 53;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Crosshairs;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 25;
            btnLimpiar.Location = new Point(176, 12);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(149, 40);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.IconChar = FontAwesome.Sharp.IconChar.Registered;
            btnGenerarReporte.IconColor = Color.Black;
            btnGenerarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGenerarReporte.IconSize = 25;
            btnGenerarReporte.Location = new Point(3, 12);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(149, 40);
            btnGenerarReporte.TabIndex = 0;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGenerarReporte.UseVisualStyleBackColor = true;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(132, 328);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(1100, 260);
            dgvReportes.TabIndex = 54;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvReportes);
            Controls.Add(pnlBotones);
            Controls.Add(cmbTipoReporte);
            Controls.Add(lbnTipoReporte);
            Controls.Add(PnlTitulo);
            Name = "FrmReportes";
            Text = "FrmReportes";
            PnlTitulo.ResumeLayout(false);
            PnlTitulo.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitulo;
        private Label lbnTitulo;
        private ComboBox cmbTipoReporte;
        private Label lbnTipoReporte;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnGenerarReporte;
        private DataGridView dgvReportes;
    }
}