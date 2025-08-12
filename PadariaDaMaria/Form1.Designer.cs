namespace PadariaDaMaria
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbRua = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(231, 250);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(106, 48);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(59, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(152, 18);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome Do Comércio \r\n";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(231, 40);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(218, 20);
            this.txbNome.TabIndex = 2;
            // 
            // txbRua
            // 
            this.txbRua.Location = new System.Drawing.Point(130, 73);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(319, 20);
            this.txbRua.TabIndex = 3;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(130, 108);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(319, 20);
            this.txbBairro.TabIndex = 4;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(59, 75);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 18);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Rua\r\n";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(130, 141);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(319, 20);
            this.txbCidade.TabIndex = 6;
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(130, 177);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(319, 20);
            this.txbEstado.TabIndex = 7;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(130, 214);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(319, 20);
            this.txbCep.TabIndex = 8;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(59, 110);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 18);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro\r\n";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(59, 140);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade\r\n";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(59, 179);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 18);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado\r\n";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(59, 216);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 18);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "Cep\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 418);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnProximo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbRua;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
    }
}

