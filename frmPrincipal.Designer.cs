namespace appComercio
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.btnCadastroReserva = new System.Windows.Forms.Button();
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.btnCadastroEditora = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLblLogin = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCadastroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroUsuario.Location = new System.Drawing.Point(3, 89);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(627, 37);
            this.btnCadastroUsuario.TabIndex = 2;
            this.btnCadastroUsuario.Text = "Cadastrar Usuário";
            this.btnCadastroUsuario.UseVisualStyleBackColor = false;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCadastroReserva
            // 
            this.btnCadastroReserva.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCadastroReserva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastroReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroReserva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroReserva.Location = new System.Drawing.Point(3, 132);
            this.btnCadastroReserva.Name = "btnCadastroReserva";
            this.btnCadastroReserva.Size = new System.Drawing.Size(627, 39);
            this.btnCadastroReserva.TabIndex = 3;
            this.btnCadastroReserva.Text = "Cadastrar Reserva";
            this.btnCadastroReserva.UseVisualStyleBackColor = false;
            this.btnCadastroReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCadastroLivro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroLivro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastroLivro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroLivro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroLivro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastroLivro.Location = new System.Drawing.Point(3, 3);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(627, 37);
            this.btnCadastroLivro.TabIndex = 0;
            this.btnCadastroLivro.Text = "Cadastrar Livro";
            this.btnCadastroLivro.UseVisualStyleBackColor = false;
            this.btnCadastroLivro.Click += new System.EventHandler(this.btnCadastroLivros_Click);
            // 
            // btnCadastroEditora
            // 
            this.btnCadastroEditora.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastroEditora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroEditora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastroEditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroEditora.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroEditora.Location = new System.Drawing.Point(3, 46);
            this.btnCadastroEditora.Name = "btnCadastroEditora";
            this.btnCadastroEditora.Size = new System.Drawing.Size(627, 37);
            this.btnCadastroEditora.TabIndex = 1;
            this.btnCadastroEditora.Text = "Cadastrar Editora";
            this.btnCadastroEditora.UseVisualStyleBackColor = false;
            this.btnCadastroEditora.Click += new System.EventHandler(this.btnCadastroEditora_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroReserva, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroEditora, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroUsuario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastroLivro, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(140, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 174);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.linkLblLogin, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(914, 450);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // linkLblLogin
            // 
            this.linkLblLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLblLogin.AutoSize = true;
            this.linkLblLogin.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLblLogin.Location = new System.Drawing.Point(403, 315);
            this.linkLblLogin.Name = "linkLblLogin";
            this.linkLblLogin.Size = new System.Drawing.Size(107, 20);
            this.linkLblLogin.TabIndex = 5;
            this.linkLblLogin.TabStop = true;
            this.linkLblLogin.Text = "Página de Login";
            this.linkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogin_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnCadastroReserva;
        private System.Windows.Forms.Button btnCadastroLivro;
        private System.Windows.Forms.Button btnCadastroEditora;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.LinkLabel linkLblLogin;
    }
}