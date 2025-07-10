using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appComercio
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Email";
            textBox1.ForeColor = Color.Gray;
            textBox2.Text = "Senha";
            textBox2.ForeColor = Color.Gray;
            textBox2.UseSystemPasswordChar = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Email";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Senha")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = "Senha";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbTelaLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
              private async void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Validações simples de campos obrigatórios
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Preencha todos os campos.", "Campos faltando", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Monta o objeto que será enviado para a API
            //Os nomes devem estar extamente iguais na API
            var novoUsuario = new
            {
                EmailUsuario = textBox1.Text.Trim(),
                SenhaUsuario = textBox2.Text.Trim()
            };

            string apiPostUrl = apiRotasController.CadastroUsuario;
            string jsonBody = JsonConvert.SerializeObject(novoUsuario);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    using (var content = new StringContent(jsonBody, Encoding.UTF8, "application/json"))
                    {
                        // ===== CHAMADA POST =====
                        HttpResponseMessage response = await client.PostAsync(apiPostUrl, content);

                        if (response.StatusCode == HttpStatusCode.Created || response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Usuário criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();          // opcional: limpa as TextBox
                            await CarregarDados();   // recarrega o DataGridView
                        }
                        else
                        {
                            string detalhe = await response.Content.ReadAsStringAsync();
                            MessageBox.Show($"Erro ao salvar: {response.StatusCode}\n{detalhe}",
                                            "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (HttpRequestException hre)
                {
                    MessageBox.Show($"Falha de comunicação com a API:\n{hre.Message}",
                                    "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado:\n{ex.Message}",
                                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            // 1) Garantir que temos um ID
            if (_idSelecionado == null)
            {
                MessageBox.Show("Selecione um registro antes de editar.", "Nenhum item selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
