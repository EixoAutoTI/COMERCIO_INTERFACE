using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appComercio
{
    public partial class frmCadastroUsuario : Form
    {
        public string email;
        public string cidade;

        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtNome.Text == "" || txtSenha.Text == "" || cbInstituicao.Text == "")
            {
                MessageBox.Show("Campo vazio. Nenhum dado foi cadastrado");
            }
            else {
                if (txtCPF.Text == "sla") //Percorrer pelo banco e procurar se o dado já está cadastrado
                {
                    MessageBox.Show("Esse usuário já está cadastrado, faça o login");
                }else
                {
                    email = txtCPF.Text;
                    cidade = txtNome.Text;
                    //adicionar o usuário no db
                    //Adicionar o usuário no dgv usuario
                }
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            
        }

        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            frmP.Show();
            this.Visible = false;
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbTelaCadastro_Enter(object sender, EventArgs e)
        {

        }
    }
}
