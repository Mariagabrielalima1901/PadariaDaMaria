namespace PadariaDaMaria
{
    partial class FrmCadastro
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
            this.txbCep = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(231, 332);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(106, 48);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "Proximo";
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
            this.txbRua.Location = new System.Drawing.Point(130, 141);
            this.txbRua.Name = "txbRua";
            this.txbRua.Size = new System.Drawing.Size(319, 20);
            this.txbRua.TabIndex = 3;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(130, 177);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(319, 20);
            this.txbBairro.TabIndex = 4;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(55, 78);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 18);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Rua\r\n";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(130, 214);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(319, 20);
            this.txbCidade.TabIndex = 6;
            // 
            // txbCep
            // 
            this.txbCep.Location = new System.Drawing.Point(130, 253);
            this.txbCep.Name = "txbCep";
            this.txbCep.Size = new System.Drawing.Size(319, 20);
            this.txbCep.TabIndex = 7;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(59, 143);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 18);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro\r\n";
            this.lblBairro.Click += new System.EventHandler(this.lblBairro_Click);
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(55, 179);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade\r\n";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(57, 216);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 18);
            this.lblEstado.TabIndex = 11;
            this.lblEstado.Text = "Estado\r\n";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCep.Location = new System.Drawing.Point(57, 255);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(38, 18);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "Cep\r\n";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(319, 20);
            this.textBox2.TabIndex = 14;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(130, 108);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(319, 20);
            this.txbNumero.TabIndex = 15;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(55, 110);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(63, 18);
            this.lblNumero.TabIndex = 18;
            this.lblNumero.Text = "Numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 418);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblCep);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.txbCep);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txbBairro);
            this.Controls.Add(this.txbRua);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnProximo);
            this.Name = "Form1";
            this.Text = "=";
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
        private System.Windows.Forms.TextBox txbCep;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblNumero;
    }
}

