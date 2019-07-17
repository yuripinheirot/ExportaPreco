namespace ExportaPreco
{
    partial class frmTabelasDePreco
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvTabelas = new System.Windows.Forms.DataGridView();
            this.dsTabelasDePreco = new ExportaPreco.dsTabelasDePreco();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idtabelaprecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabelasDePreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Location = new System.Drawing.Point(447, 285);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(366, 285);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "&Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // dgvTabelas
            // 
            this.dgvTabelas.AllowUserToAddRows = false;
            this.dgvTabelas.AllowUserToDeleteRows = false;
            this.dgvTabelas.AllowUserToOrderColumns = true;
            this.dgvTabelas.AutoGenerateColumns = false;
            this.dgvTabelas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTabelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtabelaprecoDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvTabelas.DataSource = this.dataTable1BindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTabelas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTabelas.Location = new System.Drawing.Point(12, 12);
            this.dgvTabelas.MultiSelect = false;
            this.dgvTabelas.Name = "dgvTabelas";
            this.dgvTabelas.ReadOnly = true;
            this.dgvTabelas.RowHeadersWidth = 24;
            this.dgvTabelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTabelas.Size = new System.Drawing.Size(510, 242);
            this.dgvTabelas.TabIndex = 0;
            this.dgvTabelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTabelas_KeyDown);
            // 
            // dsTabelasDePreco
            // 
            this.dsTabelasDePreco.DataSetName = "dsTabelasDePreco";
            this.dsTabelasDePreco.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dsTabelasDePreco;
            // 
            // idtabelaprecoDataGridViewTextBoxColumn
            // 
            this.idtabelaprecoDataGridViewTextBoxColumn.DataPropertyName = "idtabelapreco";
            this.idtabelaprecoDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idtabelaprecoDataGridViewTextBoxColumn.Name = "idtabelaprecoDataGridViewTextBoxColumn";
            this.idtabelaprecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtabelaprecoDataGridViewTextBoxColumn.Width = 65;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 400;
            // 
            // frmTabelasDePreco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.Controls.Add(this.dgvTabelas);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTabelasDePreco";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabelas de preço";
            this.Load += new System.EventHandler(this.FrmTabelasDePreco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTabelasDePreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvTabelas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtabelaprecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private dsTabelasDePreco dsTabelasDePreco;
    }
}