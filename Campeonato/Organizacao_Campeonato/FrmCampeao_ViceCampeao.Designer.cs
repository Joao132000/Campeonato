namespace Campeonato
{
    partial class FrmCampeao_ViceCampeao
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmdAtualizar = new MetroFramework.Controls.MetroButton();
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.txtNomeCamp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbCampeao = new MetroFramework.Controls.MetroComboBox();
            this.cmbViceCampeao = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 264);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Campeão:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 307);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Vice-Campeão:";
            // 
            // cmdAtualizar
            // 
            this.cmdAtualizar.Location = new System.Drawing.Point(178, 357);
            this.cmdAtualizar.Name = "cmdAtualizar";
            this.cmdAtualizar.Size = new System.Drawing.Size(75, 23);
            this.cmdAtualizar.TabIndex = 3;
            this.cmdAtualizar.Text = "Atualizar";
            this.cmdAtualizar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(366, 77);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(82, 23);
            this.cmdPesquisar.TabIndex = 9;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click_1);
            // 
            // txtNomeCamp
            // 
            this.txtNomeCamp.Location = new System.Drawing.Point(178, 80);
            this.txtNomeCamp.Name = "txtNomeCamp";
            this.txtNomeCamp.Size = new System.Drawing.Size(122, 23);
            this.txtNomeCamp.TabIndex = 8;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(130, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Nome Campeonato:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(406, 141);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbCampeao
            // 
            this.cmbCampeao.FormattingEnabled = true;
            this.cmbCampeao.ItemHeight = 23;
            this.cmbCampeao.Location = new System.Drawing.Point(178, 264);
            this.cmbCampeao.Name = "cmbCampeao";
            this.cmbCampeao.Size = new System.Drawing.Size(159, 29);
            this.cmbCampeao.TabIndex = 10;
            // 
            // cmbViceCampeao
            // 
            this.cmbViceCampeao.FormattingEnabled = true;
            this.cmbViceCampeao.ItemHeight = 23;
            this.cmbViceCampeao.Location = new System.Drawing.Point(178, 300);
            this.cmbViceCampeao.Name = "cmbViceCampeao";
            this.cmbViceCampeao.Size = new System.Drawing.Size(159, 29);
            this.cmbViceCampeao.TabIndex = 11;
            // 
            // FrmCampeao_ViceCampeao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 432);
            this.Controls.Add(this.cmbViceCampeao);
            this.Controls.Add(this.cmbCampeao);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.txtNomeCamp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdAtualizar);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmCampeao_ViceCampeao";
            this.Text = "Campeao e Vice-Campeao do Campeonato";
            this.Load += new System.EventHandler(this.FrmCampeao_ViceCampeao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton cmdAtualizar;
        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private MetroFramework.Controls.MetroTextBox txtNomeCamp;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroComboBox cmbCampeao;
        private MetroFramework.Controls.MetroComboBox cmbViceCampeao;
    }
}