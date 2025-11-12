using System;
using System.Windows.Forms;

namespace PadariaDaMaria
{
    public partial class frmTelaCentral : Form
    {
        private int usuarioId;
        private string nomeUsuario;

        public frmTelaCentral(int usuarioId, string nomeUsuario)
        {
            InitializeComponent();
            this.usuarioId = usuarioId;
            this.nomeUsuario = nomeUsuario;
        }

        private void frmTelaCentral_Load(object sender, EventArgs e)
        {
            lblBoasVindas.Text = $"Bem-vindo, {nomeUsuario}!";
            lblData.Text = $"Data: {DateTime.Now:dd/MM/yyyy}";
            lblHora.Text = $"Hora: {DateTime.Now:HH:mm}";
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de Estoque", "Estoque",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de Vendas", "Vendas",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de Clientes", "Clientes",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de Relatórios", "Relatórios",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abrir tela de Configurações", "Configurações",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente sair do sistema?", "Sair",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fazer logout?", "Logout",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmLogin login = new frmLogin();
                login.Show();
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = $"Hora: {DateTime.Now:HH:mm:ss}";
        }
    }
}