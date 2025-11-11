namespace PadariaDaMaria
{
    partial class TelaPrincipal
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
            this.btnProximo = new System.Windows.Forms.Button();
            this.lblTipoDoProduto = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblCadastreSeuProduto = new System.Windows.Forms.Label();
            this.txbTipoDeProduto = new System.Windows.Forms.TextBox();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(329, 281);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 0;
            this.btnProximo.Text = "button1";
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // lblTipoDoProduto
            // 
            this.lblTipoDoProduto.AutoSize = true;
            this.lblTipoDoProduto.Location = new System.Drawing.Point(137, 136);
            this.lblTipoDoProduto.Name = "lblTipoDoProduto";
            this.lblTipoDoProduto.Size = new System.Drawing.Size(85, 13);
            this.lblTipoDoProduto.TabIndex = 1;
            this.lblTipoDoProduto.Text = "Tipo Do Produto";
            this.lblTipoDoProduto.Click += new System.EventHandler(this.lblTipoDoProduto_Click);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(262, 181);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(210, 20);
            this.txbNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(137, 188);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(137, 237);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblCadastreSeuProduto
            // 
            this.lblCadastreSeuProduto.AutoSize = true;
            this.lblCadastreSeuProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastreSeuProduto.Location = new System.Drawing.Point(133, 47);
            this.lblCadastreSeuProduto.Name = "lblCadastreSeuProduto";
            this.lblCadastreSeuProduto.Size = new System.Drawing.Size(408, 42);
            this.lblCadastreSeuProduto.TabIndex = 5;
            this.lblCadastreSeuProduto.Text = "Cadastre Seu Produto";
            // 
            // txbTipoDeProduto
            // 
            this.txbTipoDeProduto.Location = new System.Drawing.Point(262, 133);
            this.txbTipoDeProduto.Name = "txbTipoDeProduto";
            this.txbTipoDeProduto.Size = new System.Drawing.Size(210, 20);
            this.txbTipoDeProduto.TabIndex = 6;
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(262, 230);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(210, 20);
            this.txbQuantidade.TabIndex = 7;
            this.txbQuantidade.TextChanged += new System.EventHandler(this.txbQuantidade_TextChanged);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbTipoDeProduto);
            this.Controls.Add(this.lblCadastreSeuProduto);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblTipoDoProduto);
            this.Controls.Add(this.btnProximo);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Label lblTipoDoProduto;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblCadastreSeuProduto;
        private System.Windows.Forms.TextBox txbTipoDeProduto;
        private System.Windows.Forms.TextBox txbQuantidade;
    }
}