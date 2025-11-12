using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PadariaDaMaria
{
    public partial class frmCadastro : Form
    {
        // <<< CORRIGIDO AQUI >>>
        // O Data Source foi atualizado para "sqlexpress" (igual ao seu print)
        private string connectionString = @"Data Source=sqlexpress;Initial Catalog=CJ3027821PR2;User Id=aluno;Password=aluno;";

        public frmCadastro()
        {
            InitializeComponent();
        }

        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open(); // Se falhar aqui, o problema ainda é a conexão
                    string query = @"
INSERT INTO Usuarios 
                                   (NomeCompleto, DataNascimento, Email, Telefone, Username, Senha) 
                                   VALUES (@NomeCompleto, @DataNascimento, @Email, @Telefone, @Username, @Senha)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NomeCompleto", txtNomeCompleto.Text.Trim());
                        cmd.Parameters.AddWithValue("@DataNascimento", dtpDataNascimento.Value);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text.Trim());
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text.Trim());
                        cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmLogin login = new frmLogin();
                            login.Show();
                            this.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601) 
                {
                    MessageBox.Show("Username ou E-mail já cadastrado!", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Erro no cadastro: {ex.Message}", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNomeCompleto.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtTelefone.Text) ||
                string.IsNullOrEmpty(txtUsername.Text) ||
                string.IsNullOrEmpty(txtSenha.Text) ||
                string.IsNullOrEmpty(txtConfirmarSenha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres!", "Atenção",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }
    }
}