namespace PadariaDaMaria
{
    partial class frmCadastroDoUsuario
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
            this.v = new System.Windows.Forms.Label();
            this.btnProximo = new System.Windows.Forms.Button();
            this.txbEmailOuTelefone = new System.Windows.Forms.TextBox();
            this.txbNomeDeUsuario = new System.Windows.Forms.TextBox();
            this.lblNomeDeUsuario = new System.Windows.Forms.Label();
            this.lblCriarUmaSenha = new System.Windows.Forms.Label();
            this.txbCriarUmaSenha = new System.Windows.Forms.TextBox();
            this.lblRepetirSenha = new System.Windows.Forms.Label();
            this.txbRepetirSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(78, 88);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(91, 13);
            this.v.TabIndex = 0;
            this.v.Text = "E-mail ou telefone";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(272, 283);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // txbEmailOuTelefone
            // 
            this.txbEmailOuTelefone.Location = new System.Drawing.Point(192, 81);
            this.txbEmailOuTelefone.Name = "txbEmailOuTelefone";
            this.txbEmailOuTelefone.Size = new System.Drawing.Size(229, 20);
            this.txbEmailOuTelefone.TabIndex = 2;
            // 
            // txbNomeDeUsuario
            // 
            this.txbNomeDeUsuario.Location = new System.Drawing.Point(192, 130);
            this.txbNomeDeUsuario.Name = "txbNomeDeUsuario";
            this.txbNomeDeUsuario.Size = new System.Drawing.Size(229, 20);
            this.txbNomeDeUsuario.TabIndex = 7;
            // 
            // lblNomeDeUsuario
            // 
            this.lblNomeDeUsuario.AutoSize = true;
            this.lblNomeDeUsuario.Location = new System.Drawing.Point(78, 137);
            this.lblNomeDeUsuario.Name = "lblNomeDeUsuario";
            this.lblNomeDeUsuario.Size = new System.Drawing.Size(87, 13);
            this.lblNomeDeUsuario.TabIndex = 8;
            this.lblNomeDeUsuario.Text = "Nome de usuario";
            // 
            // lblCriarUmaSenha
            // 
            this.lblCriarUmaSenha.AutoSize = true;
            this.lblCriarUmaSenha.Location = new System.Drawing.Point(78, 185);
            this.lblCriarUmaSenha.Name = "lblCriarUmaSenha";
            this.lblCriarUmaSenha.Size = new System.Drawing.Size(87, 13);
            this.lblCriarUmaSenha.TabIndex = 9;
            this.lblCriarUmaSenha.Text = "Criar Uma Senha";
            // 
            // txbCriarUmaSenha
            // 
            this.txbCriarUmaSenha.Location = new System.Drawing.Point(193, 178);
            this.txbCriarUmaSenha.Name = "txbCriarUmaSenha";
            this.txbCriarUmaSenha.Size = new System.Drawing.Size(228, 20);
            this.txbCriarUmaSenha.TabIndex = 10;
            // 
            // lblRepetirSenha
            // 
            this.lblRepetirSenha.AutoSize = true;
            this.lblRepetirSenha.Location = new System.Drawing.Point(78, 235);
            this.lblRepetirSenha.Name = "lblRepetirSenha";
            this.lblRepetirSenha.Size = new System.Drawing.Size(75, 13);
            this.lblRepetirSenha.TabIndex = 11;
            this.lblRepetirSenha.Text = "Repetir Senha";
            // 
            // txbRepetirSenha
            // 
            this.txbRepetirSenha.Location = new System.Drawing.Point(192, 228);
            this.txbRepetirSenha.Name = "txbRepetirSenha";
            this.txbRepetirSenha.Size = new System.Drawing.Size(229, 20);
            this.txbRepetirSenha.TabIndex = 12;
            // 
            // frmCadastroDoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.txbRepetirSenha);
            this.Controls.Add(this.lblRepetirSenha);
            this.Controls.Add(this.txbCriarUmaSenha);
            this.Controls.Add(this.lblCriarUmaSenha);
            this.Controls.Add(this.lblNomeDeUsuario);
            this.Controls.Add(this.txbNomeDeUsuario);
            this.Controls.Add(this.txbEmailOuTelefone);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.v);
            this.Name = "frmCadastroDoUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.TextBox txbEmailOuTelefone;
        private System.Windows.Forms.TextBox txbNomeDeUsuario;
        private System.Windows.Forms.Label lblNomeDeUsuario;
        private System.Windows.Forms.Label lblCriarUmaSenha;
        private System.Windows.Forms.TextBox txbCriarUmaSenha;
        private System.Windows.Forms.Label lblRepetirSenha;
        private System.Windows.Forms.TextBox txbRepetirSenha;
    }
}