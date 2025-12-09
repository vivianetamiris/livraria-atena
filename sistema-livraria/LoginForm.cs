using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_FontChanged(object sender, EventArgs e)
        {

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Exemplo de lógica de login
            if (txtUsuario.Text == "atena" && txtSenha.Text == "1234")
            {
                MainForm main = new MainForm();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

