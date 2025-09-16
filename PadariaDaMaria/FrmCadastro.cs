using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PadariaDaMaria
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string rua = txbRua.Text;
            string numero = txbNumero.Text;
            string bairro = txbBairro.Text;
            string cidade = txbCidade.Text;
            string estado = txbCep.Text;
            string cep = txbCep.Text;
            MessageBox.Show("Nome:" + nome +
                            "\nRua:" + rua +
                            "\nNumero" + numero +
                            "\nBairro:" + bairro +
                            "\nCidade:" + cidade +
                            "\nEstado:" + estado +
                            "\nCep:" + cep);

            string connectionString = "Server=sqlexpress;Database=CJ3027821PR2;USER ID=aluno;PASSWORD=aluno;";
            // Se for usar login/senha SQL Server:
            // string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=usuario;Password=senha;";

            // Comando SQL de INSERT com parâmetros
            string query = @"INSERT INTO tabeladapadaria (Nome, Rua, Numero, Bairro, Cidade, Estado, Cep)
                         VALUES (@Nome, @Rua, @Numero, @Bairro, @Cidade, @Estado, @Cep)";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Passa os valores como parâmetros
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Rua", rua);
                        cmd.Parameters.AddWithValue("@Numero", numero);
                        cmd.Parameters.AddWithValue("@Bairro", bairro);                
                        cmd.Parameters.AddWithValue("@Cidade", cidade);
                        cmd.Parameters.AddWithValue("@Estado", estado);
                        cmd.Parameters.AddWithValue("@Cep", cep);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir dados: " + ex.Message);
            }

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
