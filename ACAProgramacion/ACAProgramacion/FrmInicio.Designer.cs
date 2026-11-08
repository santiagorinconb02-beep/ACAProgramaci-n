namespace ACAProgramacion
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            pictureBoxFondo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFondo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFondo
            // 
            pictureBoxFondo.BackColor = Color.Transparent;
            pictureBoxFondo.Image = (Image)resources.GetObject("pictureBoxFondo.Image");
            pictureBoxFondo.Location = new Point(-198, -1);
            pictureBoxFondo.Name = "pictureBoxFondo";
            pictureBoxFondo.Size = new Size(2100, 1000);
            pictureBoxFondo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFondo.TabIndex = 4;
            pictureBoxFondo.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(pictureBoxFondo);
            Name = "FrmInicio";
            Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFondo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxFondo;
    }
}