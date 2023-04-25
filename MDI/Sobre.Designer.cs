namespace MDI
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.lbSobreTitulo = new System.Windows.Forms.Label();
            this.pictureBoxImagemSobre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemSobre)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSobreTitulo
            // 
            this.lbSobreTitulo.AutoSize = true;
            this.lbSobreTitulo.Location = new System.Drawing.Point(407, 108);
            this.lbSobreTitulo.Name = "lbSobreTitulo";
            this.lbSobreTitulo.Size = new System.Drawing.Size(318, 66);
            this.lbSobreTitulo.TabIndex = 0;
            this.lbSobreTitulo.Text = "Feito Por: João Luiz Martins Neto\r\n\r\n      Programas para Desktop\r\n";
            // 
            // pictureBoxImagemSobre
            // 
            this.pictureBoxImagemSobre.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImagemSobre.Image")));
            this.pictureBoxImagemSobre.Location = new System.Drawing.Point(51, 85);
            this.pictureBoxImagemSobre.Name = "pictureBoxImagemSobre";
            this.pictureBoxImagemSobre.Size = new System.Drawing.Size(337, 328);
            this.pictureBoxImagemSobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagemSobre.TabIndex = 1;
            this.pictureBoxImagemSobre.TabStop = false;
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 511);
            this.Controls.Add(this.pictureBoxImagemSobre);
            this.Controls.Add(this.lbSobreTitulo);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sobre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagemSobre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbSobreTitulo;
        private PictureBox pictureBoxImagemSobre;
    }
}