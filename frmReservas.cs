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
    public partial class frmReservas : Form
    {
        public string livro;
        public string usuario;
        public string editora;
        public frmReservas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            this.Visible = false;
            frmP.Show(); 
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (cbUsuario.Text == "" || cbLivro.Text == "" || dtReserva.Text == "")
            {
                MessageBox.Show("Campo vazio. Nenhum dado foi cadastrado");
            }

            livro =cbLivro.Text;
            editora = cbEditora.Text;
            usuario = cbUsuario.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Incluir data atual 
            DateTime d = DateTime.Now;
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbEditora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
