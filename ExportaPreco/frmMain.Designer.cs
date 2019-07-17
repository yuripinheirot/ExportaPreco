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
            this.tbxTabela.Size = new System.Drawing.Size(351, 20);
            this.tbxTabela.TabIndex = 5;
            // 
            // tbxIdTabela
            // 
            this.tbxIdTabela.Location = new System.Drawing.Point(15, 25);
            this.tbxIdTabela.Name = "tbxIdTabela";
            this.tbxIdTabela.Size = new System.Drawing.Size(47, 20);
            this.tbxIdTabela.TabIndex = 4;
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
            this.label6.Location = new System.Drawing.Point(12, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Diretório de saída";
            // 
            // tbxDiretorio
            // 
            this.tbxDiretorio.Location = new System.Drawing.Point(15, 64);
            this.tbxDiretorio.Name = "tbxDiretorio";
            this.tbxDiretorio.Size = new System.Drawing.Size(404, 20);
            this.tbxDiretorio.TabIndex = 6;
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
            this.progressBar1.TabIndex = 9;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(433, 176);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tbxDiretorio);
            this.Controls.Add(this.tbxIdTabela);
            this.Controls.Add(this.tbxTabela);
            this.Controls.Add(this.lblProgresso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
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
    }
}

