using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace ExportaPreco
{
    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Properties.Settings.Default.diretorio))
                {
                    tbxDiretorio.Text = Properties.Settings.Default.diretorio;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TbxIdTabela_KeyDown(object sender, KeyEventArgs e)
        {
            Data data = new Data();

            if (e.KeyCode == Keys.F2)
            {
                if (data.VerificaConexao() == false)
                {
                    MessageBox.Show("Não foi possível conectar a base de dados apontada, verifique.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                frmTabelasDePreco tabelas = new frmTabelasDePreco(this);
                tabelas.ShowDialog();
            }
        }

        private void TbxIdTabela_TextChanged(object sender, EventArgs e)
        {
            Data data = new Data();

            if (data.VerificaConexao() == false)
            {
                MessageBox.Show("Não foi possível conectar a base de dados apontada, verifique.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!string.IsNullOrEmpty(tbxIdTabela.Text))
            {
                tbxTabela.Text = data.NomeTabela(tbxIdTabela.Text);
            }
            else
            {
                tbxTabela.Text = null;
            }
        }

        private async void BtnExportar_Click(object sender, EventArgs e)
        {
            Data data = new Data();

            if (string.IsNullOrWhiteSpace(tbxIdTabela.Text) || string.IsNullOrWhiteSpace(tbxDiretorio.Text))
            {
                MessageBox.Show("Dados incompletos, por favor verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (tbxTabela.Text == "TABELA NÃO ENCONTRADA!")
            {
                MessageBox.Show("Não é possível exportar registros de uma tabela que não foi encontrada.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (data.VerificaConexao() == false)
            {
                MessageBox.Show("Não foi possível conectar a base de dados apontada, verifique.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!Directory.Exists(tbxDiretorio.Text))
            {
                MessageBox.Show("Diretório de saída apontado não existe, verifique.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            await data.ExportarRegistro(tbxDiretorio.Text, tbxIdTabela.Text, progressBar1, lblConcluido);

        }

        private void TbxDiretorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    tbxDiretorio.Text = folder.SelectedPath;
                }
            }
        }
    }
}
