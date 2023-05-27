namespace MDI
{
    partial class frmDetalhes
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
            components = new System.ComponentModel.Container();
            btnOk = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtDetalhesTelefone = new TextBox();
            bsDetalhe = new BindingSource(components);
            label2 = new Label();
            txtDetalhesEndereco = new TextBox();
            label1 = new Label();
            txtDetalhesNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).BeginInit();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(272, 263);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(65, 30);
            btnOk.TabIndex = 21;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(201, 263);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(65, 30);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 161);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 19;
            label3.Text = "Telefone";
            // 
            // txtDetalhesTelefone
            // 
            txtDetalhesTelefone.DataBindings.Add(new Binding("Text", bsDetalhe, "Telefone", true));
            txtDetalhesTelefone.Location = new Point(12, 179);
            txtDetalhesTelefone.Name = "txtDetalhesTelefone";
            txtDetalhesTelefone.Size = new Size(309, 23);
            txtDetalhesTelefone.TabIndex = 18;
            // 
            // bsDetalhe
            // 
            bsDetalhe.DataSource = typeof(DAL.Agenda);
            bsDetalhe.CurrentChanged += bsDetalhe_CurrentChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 105);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 17;
            label2.Text = "Endereco";
            // 
            // txtDetalhesEndereco
            // 
            txtDetalhesEndereco.DataBindings.Add(new Binding("Text", bsDetalhe, "Endereco", true));
            txtDetalhesEndereco.Location = new Point(12, 123);
            txtDetalhesEndereco.Name = "txtDetalhesEndereco";
            txtDetalhesEndereco.Size = new Size(309, 23);
            txtDetalhesEndereco.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 15;
            label1.Text = "Nome";
            // 
            // txtDetalhesNome
            // 
            txtDetalhesNome.DataBindings.Add(new Binding("Text", bsDetalhe, "Nome", true));
            txtDetalhesNome.Location = new Point(12, 61);
            txtDetalhesNome.Name = "txtDetalhesNome";
            txtDetalhesNome.Size = new Size(309, 23);
            txtDetalhesNome.TabIndex = 14;
            // 
            // frmDetalhes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 307);
            Controls.Add(btnOk);
            Controls.Add(btnCancelar);
            Controls.Add(label3);
            Controls.Add(txtDetalhesTelefone);
            Controls.Add(label2);
            Controls.Add(txtDetalhesEndereco);
            Controls.Add(label1);
            Controls.Add(txtDetalhesNome);
            Name = "frmDetalhes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmDetalhes";
            Load += frmDetalhes_Load;
            ((System.ComponentModel.ISupportInitialize)bsDetalhe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Button btnCancelar;
        private Label label3;
        private TextBox txtDetalhesTelefone;
        private Label label2;
        private TextBox txtDetalhesEndereco;
        private Label label1;
        private TextBox txtDetalhesNome;
        private BindingSource bsDetalhe;
    }
}