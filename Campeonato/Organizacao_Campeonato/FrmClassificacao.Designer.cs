namespace Campeonato
{
    partial class FrmClassificacao
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
            this.cmbCampeonato = new MetroFramework.Controls.MetroComboBox();
            this.cmdPesquisar = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(148, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Escolha o Campeonato:";
            // 
            // cmbCampeonato
            // 
            this.cmbCampeonato.FormattingEnabled = true;
            this.cmbCampeonato.ItemHeight = 23;
            this.cmbCampeonato.Location = new System.Drawing.Point(190, 83);
            this.cmbCampeonato.Name = "cmbCampeonato";
            this.cmbCampeonato.Size = new System.Drawing.Size(121, 29);
            this.cmbCampeonato.TabIndex = 1;
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Location = new System.Drawing.Point(401, 79);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(93, 33);
            this.cmdPesquisar.TabIndex = 2;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 267);
            this.dataGridView1.TabIndex = 3;
            // 
            // FrmClassificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdPesquisar);
            this.Controls.Add(this.cmbCampeonato);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmClassificacao";
            this.Text = "Classificaçao";
            this.Load += new System.EventHandler(this.FrmClassificacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cmbCampeonato;
        private MetroFramework.Controls.MetroButton cmdPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}