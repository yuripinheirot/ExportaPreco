namespace ExportaPreco
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTabela = new System.Windows.Forms.TextBox();
            this.tbxIdTabela = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxDiretorio = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgresso = new System.Windows.Forms.Label();
            this.Ajuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblConcluido = new System.Windows.Forms.Label();
            this.tbxDataAlteracao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // tbxTabela
            // 
            this.tbxTabela.Location = new System.Drawing.Point(68, 25);
            this.tbxTabela.Name = "tbxTabela";
            this.tbxTabela.ReadOnly = true;
            this.tbxTabela.Size = new System.Drawing.Size(250, 20);
            this.tbxTabela.TabIndex = 1;
            // 
            // tbxIdTabela
            // 
            this.tbxIdTabela.Location = new System.Drawing.Point(15, 25);
            this.tbxIdTabela.Name = "tbxIdTabela";
            this.tbxIdTabela.Size = new System.Drawing.Size(47, 20);
            this.tbxIdTabela.TabIndex = 0;
            this.tbxIdTabela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ajuda.SetToolTip(this.tbxIdTabela, "Pressione F2 para localizar uma tabela de preço.");
            this.tbxIdTabela.TextChanged += new System.EventHandler(this.TbxIdTabela_TextChanged);
            this.tbxIdTabela.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxIdTabela_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tabela";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diretório de saída";
            // 
            // tbxDiretorio
            // 
            this.tbxDiretorio.Location = new System.Drawing.Point(68, 64);
            this.tbxDiretorio.Name = "tbxDiretorio";
            this.tbxDiretorio.Size = new System.Drawing.Size(351, 20);
            this.tbxDiretorio.TabIndex = 4;
            this.Ajuda.SetToolTip(this.tbxDiretorio, "Pressione F2 para selecionar um diretório de saída.");
            this.tbxDiretorio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbxDiretorio_KeyDown);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(344, 144);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExportar.Location = new System.Drawing.Point(263, 144);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 7;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // lblProgresso
            // 
            this.lblProgresso.AutoSize = true;
            this.lblProgresso.Location = new System.Drawing.Point(12, 88);
            this.lblProgresso.Name = "lblProgresso";
            this.lblProgresso.Size = new System.Drawing.Size(54, 13);
            this.lblProgresso.TabIndex = 0;
            this.lblProgresso.Text = "Progresso";
            // 
            // Ajuda
            // 
            this.Ajuda.AutomaticDelay = 350;
            this.Ajuda.AutoPopDelay = 5000;
            this.Ajuda.InitialDelay = 350;
            this.Ajuda.IsBalloon = true;
            this.Ajuda.ReshowDelay = 70;
            this.Ajuda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Ajuda.ToolTipTitle = "Info";
            // 
            // lblConcluido
            // 
            this.lblConcluido.AutoSize = true;
            this.lblConcluido.Location = new System.Drawing.Point(12, 149);
            this.lblConcluido.Name = "lblConcluido";
            this.lblConcluido.Size = new System.Drawing.Size(76, 13);
            this.lblConcluido.TabIndex = 6;
            this.lblConcluido.Text = "Concluído 0/0";
            // 
            // tbxDataAlteracao
            // 
            this.tbxDataAlteracao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbxDataAlteracao.Location = new System.Drawing.Point(324, 25);
            this.tbxDataAlteracao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.tbxDataAlteracao.Name = "tbxDataAlteracao";
            this.tbxDataAlteracao.Size = new System.Drawing.Size(95, 20);
            this.tbxDataAlteracao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alterados a partir de";
            // 
            // tbxEmpresa
            // 
            this.tbxEmpresa.Location = new System.Drawing.Point(15, 64);
            this.tbxEmpresa.Name = "tbxEmpresa";
            this.tbxEmpresa.Size = new System.Drawing.Size(47, 20);
            this.tbxEmpresa.TabIndex = 3;
            this.tbxEmpresa.Text = "01";
            this.tbxEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Empresa";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(433, 176);
            this.Controls.Add(this.tbxEmpresa);
            this.Controls.Add(this.tbxDataAlteracao);
            this.Controls.Add(this.lblConcluido);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tbxDiretorio);
            this.Controls.Add(this.tbxIdTabela);
            this.Controls.Add(this.tbxTabela);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exporta preço";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxDiretorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExportar;
        public System.Windows.Forms.TextBox tbxTabela;
        public System.Windows.Forms.TextBox tbxIdTabela;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgresso;
        private System.Windows.Forms.ToolTip Ajuda;
        private System.Windows.Forms.Label lblConcluido;
        private System.Windows.Forms.DateTimePicker tbxDataAlteracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

