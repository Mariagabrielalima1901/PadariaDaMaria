namespace PadariaDaMaria
{
    partial class FrmClientes
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNomeDoUsuario = new System.Windows.Forms.Label();
            this.txbNomeDoUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(285, 230);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // lblNomeDoUsuario
            // 
            this.lblNomeDoUsuario.AutoSize = true;
            this.lblNomeDoUsuario.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDoUsuario.Location = new System.Drawing.Point(155, 139);
            this.lblNomeDoUsuario.Name = "lblNomeDoUsuario";
            this.lblNomeDoUsuario.Size = new System.Drawing.Size(171, 24);
            this.lblNomeDoUsuario.TabIndex = 1;
            this.lblNomeDoUsuario.Text = "Nome do Usuario";
            // 
            // txbNomeDoUsuario
            // 
            this.txbNomeDoUsuario.Location = new System.Drawing.Point(336, 139);
            this.txbNomeDoUsuario.Name = "txbNomeDoUsuario";
            this.txbNomeDoUsuario.Size = new System.Drawing.Size(238, 20);
            this.txbNomeDoUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(155, 180);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 24);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(336, 180);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(238, 20);
            this.txbSenha.TabIndex = 4;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txbNomeDoUsuario);
            this.Controls.Add(this.lblNomeDoUsuario);
            this.Controls.Add(this.btnEntrar);
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNomeDoUsuario;
        private System.Windows.Forms.TextBox txbNomeDoUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbSenha;
    }
}