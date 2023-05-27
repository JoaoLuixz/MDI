namespace MDI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStripMainForm = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            gfdgdToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cEPToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuStripMainForm.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainForm
            // 
            menuStripMainForm.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, cEPToolStripMenuItem, sobreToolStripMenuItem });
            menuStripMainForm.Location = new Point(0, 0);
            menuStripMainForm.Name = "menuStripMainForm";
            menuStripMainForm.Size = new Size(1009, 24);
            menuStripMainForm.TabIndex = 1;
            menuStripMainForm.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gfdgdToolStripMenuItem, sairToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(66, 20);
            cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // gfdgdToolStripMenuItem
            // 
            gfdgdToolStripMenuItem.Name = "gfdgdToolStripMenuItem";
            gfdgdToolStripMenuItem.Size = new Size(180, 22);
            gfdgdToolStripMenuItem.Text = "Agenda";
            gfdgdToolStripMenuItem.Click += gfdgdToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // cEPToolStripMenuItem
            // 
            cEPToolStripMenuItem.Name = "cEPToolStripMenuItem";
            cEPToolStripMenuItem.Size = new Size(40, 20);
            cEPToolStripMenuItem.Text = "CEP";
            cEPToolStripMenuItem.Click += cEPToolStripMenuItem_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 768);
            Controls.Add(menuStripMainForm);
            Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStripMainForm;
            Margin = new Padding(6, 4, 6, 4);
            Name = "MainForm";
            Text = "MDI";
            Load += MainForm_Load;
            menuStripMainForm.ResumeLayout(false);
            menuStripMainForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainForm;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem cEPToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem gfdgdToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
    }
}