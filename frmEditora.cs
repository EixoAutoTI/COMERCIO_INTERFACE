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
    public partial class frmEditora : Form
    {
        public frmEditora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void linklblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrincipal frmP = new frmPrincipal();
            frmP.Show();
            this.Visible = false;
        }

        private void frmEditora_Load(object sender, EventArgs e)
        {
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editora já cadastrada, insira os dados de uma nova editora");
            //Consultar o banco para checar se não há uma editora já cadastrada com o mesmo nome e se não adicionar editora no banco
        }

        private void cbLivro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
