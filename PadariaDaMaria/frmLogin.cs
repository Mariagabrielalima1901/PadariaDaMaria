using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDaMaria
{
    public partial class frmLogin : Form
    {
        // <<< CORRIGIDO AQUI >>>
        // O Data Source foi atualizado para "sqlexpress" (igual ao seu print)
        private string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027821PR2;User Id=aluno;Password=aluno;";


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string senha = txtSenha.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Se falhar aqui, o problema é a conexão
                    string query = "SELECT Id, NomeCompleto FROM Usuarios WHERE Username = @Username AND Senha = @Senha";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Senha", senha);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int usuarioId = reader.GetInt32(0);
                                string nomeCompleto = reader.GetString(1);

                                frmTelaCentral telaCentral = new frmTelaCentral(usuarioId, nomeCompleto);
                                telaCentral.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Usuário ou senha incorretos!", "Erro no login",
                                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}