using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExportaPreco
{
    public partial class frmTabelasDePreco : Form
    {
        frmMain main = null;

        public frmTabelasDePreco()
        {
            InitializeComponent();
        }
        public frmTabelasDePreco(frmMain main)
        {
            InitializeComponent();
            this.main = main;
        }

        private void FrmTabelasDePreco_Load(object sender, EventArgs e)
        {
            Data data = new Data();

            try
            {
                dgvTabelas.DataSource = data.BuscaTabelas();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvTabelas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnInserir_Click(sender,e);
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            main.tbxIdTabela.Text = dgvTabelas.CurrentRow.Cells[0].Value.ToString();
            main.tbxTabela.Text = dgvTabelas.CurrentRow.Cells[1].Value.ToString();
            Close();
        }
    }
}
