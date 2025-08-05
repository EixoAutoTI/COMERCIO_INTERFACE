using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnLogin_Click_2(object sender, EventArgs e)
        {
            if (txtEmailUsuario.Text == "BlibliComicCEntreprise@hotmail.com.br" && txtSenha.Text == "J9K7M5R9")
            {
                btnLogin.Text = "Login realizado";
                frmPrincipal frmP = new frmPrincipal();
                this.Visible = false;
                frmP.Show();
            }
            else
            {
                MessageBox.Show("Email e/ou senha incorretos. Tente novamente");
                txtEmailUsuario.Text = txtSenha.Text = "";
            }
        }

        private void txtEmailUsuario_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void txtEmailUsuario_Click(object sender, EventArgs e)
        {
            txtEmailUsuario.Text = "";
            txtEmailUsuario.ForeColor = Color.Black;

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
        }

        private void gbTelaLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
