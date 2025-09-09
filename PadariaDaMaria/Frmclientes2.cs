using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PadariaDaMaria
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        string NomeDoUsuario = txbNomeDoUsuario.Text;

        string Senha = txbSenha.Text;
        MessageBox.Show("Nome do usuario:" + NomeDoUsuario +
                        "\nSenha:" + Senha);

        string connectionString = "Server=sqlexpress;Database=CJ3027821PR2;USER ID=aluno;PASSWORD=aluno;";
        // Se for usar login/senha SQL Server:
        // string connectionString = "Server=SEU_SERVIDOR;Database=SEU_BANCO;User Id=usuario;Password=senha;";

        // Comando SQL de INSERT com parâmetros
        string query = @"INSERT INTO Clientes (NomeDoUsuario,Senha)
                         VALUES (@NomeDoUsuario, @Senha)";

        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Passa os valores como parâmetros
                    cmd.Parameters.AddWithValue("@NomeDoUsuario", NomeDoUsuario);
                        cmd.Parameters.AddWithValue("@Senha", Senha);


                    cmd.ExecuteNonQuery();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao inserir dados: " + ex.Message);
        }

    }

    private void lblNomeDeUsuario_Click(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
}
