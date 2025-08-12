using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnProximo_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string rua = txbRua.Text;
            string bairro = txbBairro.Text;
            string cidade = txbCidade.Text;
            string estado = txbEstado.Text;
            string cep = txbCep.Text;
            MessageBox.Show("Nome:" + nome+
                            "\nRua:" + rua+
                            "\nBairro:" + bairro+
                            "\nCidade:" + cidade+
                            "\nEstado:" + estado+
                            "\nCep:" + cep);
            
        }
    }
}
